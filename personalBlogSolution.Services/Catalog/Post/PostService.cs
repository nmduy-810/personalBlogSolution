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
using personalBlogSolution.ViewModels.Catalog.Post;

namespace personalBlogSolution.Services.Catalog.Post
{
    public class PostService: IPostService
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
        
        public async Task<List<PostVM>> GetAll()
        {
            //1. Select Join Query
            var query = from p in _context.Posts
                join pic in _context.PostInCategories on p.Id equals pic.PostId
                join c in _context.Categories on pic.CategoryId equals c.Id
                select new {p, pic, c};

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

            return data;
        }

        public async Task<PostVM> GetById(int postId)
        {
            var post = await _context.Posts.FindAsync(postId);
            
            var categories = await (from c in _context.Categories
                join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                join pic in _context.PostInCategories on c.Id equals pic.CategoryId
                where pic.PostId == postId
                select ct.Name).ToListAsync();
            
            var image = await _context.PostImages.Where(x => x.PostId == postId && x.IsDefault).FirstOrDefaultAsync();

            var postViewModel = new PostVM()
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
            return postViewModel;
        }

        public async Task<int> Create(PostCreateRequest request)
        {
            var post = new Data.Entities.Post()
            {
                Title = request.Title,
                Summary = request.Summary,
                SeoTitle = request.SeoTitle,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
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

            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
            return post.Id;
        }

        public async Task<int> Update(PostUpdateRequest request)
        {
            var post = await _context.Posts.FindAsync(request.Id);

            if (post == null)
            {
                throw new Exception($"Cannot find a post with id : {request.Id}");
            }

            post.Title = request.Title;
            post.Summary = request.Summary;
            post.SeoTitle = request.SeoTitle;

            if (request.ThumbnailImage == null) return await _context.SaveChangesAsync();
            var thumbnailImage = 
                await _context.PostImages.FirstOrDefaultAsync(x => x.IsDefault && x.PostId == request.Id);

            thumbnailImage.FileSize = request.ThumbnailImage.Length;
            thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
            _context.PostImages.Update(thumbnailImage);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(PostDeleteRequest request)
        {
            var post = await _context.Posts.FindAsync(request.Id);
            if (post == null)
            {
                throw new Exception($"Cannot find a post: {request.Id}");
            }
            
            var images = _context.PostImages.Where(x => x.PostId == request.Id);
            foreach (var image in images)
            {
                await _storageService.DeleteFileAsync(image.ImagePath);
            }

            _context.Posts.Remove(post);
            return await _context.SaveChangesAsync();
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