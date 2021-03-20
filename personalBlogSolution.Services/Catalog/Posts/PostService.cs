using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using personalBlogSolution.Data.EF;
using personalBlogSolution.Data.Entities;
using personalBlogSolution.Services.Common;
using personalBlogSolution.Utilities.Constants;
using personalBlogSolution.ViewModels.Catalog.Post;
using personalBlogSolution.ViewModels.Common.ApiResult;

namespace personalBlogSolution.Services.Catalog.Posts
{
    public class PostService : IPostService
    {
        private readonly PersonalBlogDbContext _context;
        private readonly IStorageService _storageService;
        private const string UserContentFolderName = "user-content";

        //Dependency Injection
        public PostService(PersonalBlogDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<ApiResult<List<PostVM>>> GetAll()
        {
            //1. Select Join Query
            var query = from p in _context.Posts
                select new {p};

            //2. Get Data
            var data = await query.Select(item => new PostVM()
            {
                Id = item.p.Id,
                Title = item.p.Title,
                Summary = item.p.Summary,
                SeoTitle = item.p.SeoTitle,
                DateCreated = item.p.DateCreated,
                DateModified = item.p.DateModified,
                ViewCount = item.p.ViewCount,
                ParentId = item.p.ParentId
            }).ToListAsync();

            return data == null ? new ApiErrorResult<List<PostVM>>(SystemConstants.Message.NotFoundDataMessage) : new ApiSuccessResult<List<PostVM>>(data);
        }

        public async Task<ApiResult<PostVM>> GetById(int postId)
        {
            //1. Find id of post
            var post = await _context.Posts.FindAsync(postId);

            if (post == null)
            {
                return new ApiErrorResult<PostVM>(SystemConstants.Message.CanNotFindIdMessage + "post table with Id: " + postId);
            }

            //2. Select category data
            var categories = await (from c in _context.Categories
                join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                join pic in _context.PostInCategories on c.Id equals pic.CategoryId
                where pic.PostId == postId
                select ct.Name).ToListAsync();

            //3. Select image data
            var image = await _context.PostImages.Where(x => x.PostId == postId && x.IsDefault)
                .FirstOrDefaultAsync();

            var data = new PostVM()
            {
                Id = post.Id,
                Title = post.Title,
                Summary = post.Summary,
                SeoTitle = post.SeoTitle,
                ViewCount = post.ViewCount,
                DateCreated = post.DateCreated,
                DateModified = post.DateModified,
                ParentId = post.ParentId,
                Categories = categories,
                ThumbnailImage = image != null ? image.ImagePath : "no-image.jpg"
            };
            
            return new ApiSuccessResult<PostVM>(data);
        }

        public async Task<ApiResult<bool>> Create(PostCreateRequest request)
        {
            var post = new Post()
            {
                Title = request.Title,
                Summary = request.Summary,
                SeoTitle = request.SeoTitle,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                UserId = request.UserId
            };

            if (request.ThumbnailImage != null)
            {
                post.PostImages = new List<PostImage>()
                {
                    new PostImage()
                    {
                        Caption = "Thumbnail Image",
                        DateCreated = DateTime.Now,
                        FileSize = request.ThumbnailImage.Length,
                        ImagePath = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true,
                        SortOrder = 1
                    }
                };
            }

            var result =  await _context.Posts.AddAsync(post);
            
            await _context.SaveChangesAsync();
            return result == null ? new ApiErrorResult<bool>("Post can't create") : new ApiSuccessResult<bool>();
        }

        public async Task<ApiResult<bool>> Update(PostUpdateRequest request)
        {
            var post = await _context.Posts.FindAsync(request.Id);
            if (post == null)
            {
                return new ApiErrorResult<bool>(SystemConstants.Message.CanNotFindIdMessage + "post table with Id: " + request.Id);
            }

            post.Title = request.Title;
            post.Summary = request.Summary;
            post.SeoTitle = request.SeoTitle;

            if (request.ThumbnailImage == null)
            {
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<bool>();
            }
            var thumbnailImage = await _context.PostImages.FirstOrDefaultAsync(x => x.IsDefault && x.PostId == request.Id);

            thumbnailImage.FileSize = request.ThumbnailImage.Length;
            thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
            _context.PostImages.Update(thumbnailImage);

            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>();
        }

        public async Task<ApiResult<bool>> Delete(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return new ApiErrorResult<bool>(SystemConstants.Message.CanNotFindIdMessage + "post table with Id: " + id);
            }

            var images = _context.PostImages.Where(x => x.PostId == id);
            foreach (var image in images)
            {
                await _storageService.DeleteFileAsync(image.ImagePath);
            }

            _context.Posts.Remove(post);
            
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>();
        }

        //Helper Methods
        public async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName?.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return "/" + UserContentFolderName + "/" + fileName;
        }
    }
}