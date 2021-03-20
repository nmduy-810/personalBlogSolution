using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using personalBlogSolution.Data.EF;
using personalBlogSolution.Data.Entities;
using personalBlogSolution.Utilities.Constants;
using personalBlogSolution.ViewModels.Catalog.Tag;
using personalBlogSolution.ViewModels.Common.ApiResult;

namespace personalBlogSolution.Services.Catalog.Tags
{
    public class TagService: ITagService
    {
        private readonly PersonalBlogDbContext _context;

        public TagService(PersonalBlogDbContext context)
        {
            _context = context;
        }
        
        public async Task<ApiResult<List<TagVM>>> GetAll()
        {
            var query = from t in _context.Tags select t;
            
            var data = await query.Select(item => new TagVM()
            {
                Title = item.Title,
                SeoTitle = item.SeoTitle,
                SeoDescription = item.SeoDescription,
                ViewCount = item.ViewCount
            }).ToListAsync();
        
            return data == null ? new ApiErrorResult<List<TagVM>>(SystemConstants.Message.NotFoundDataMessage) : new ApiSuccessResult<List<TagVM>>(data);
        }

        public async Task<ApiResult<bool>> Create(TagCreateRequest request)
        {
            var tag = new Tag()
            {
                Title = request.Title,
                SeoTitle = request.SeoTitle,
                SeoDescription = request.SeoDescription
            };
        
            var result = await _context.Tags.AddAsync(tag);
        
            await _context.SaveChangesAsync();
        
            return result == null
                ? new ApiErrorResult<bool>(SystemConstants.Message.DataNotCreateSuccessful)
                : new ApiSuccessResult<bool>();
        }

        public async Task<ApiResult<bool>> Update(TagUpdateRequest request)
        {
            var tag = await _context.Tags.FindAsync(request.Id);
        
            if (tag == null)
            {
                return new ApiErrorResult<bool>(SystemConstants.Message.CanNotFindIdMessage + "tag table with Id: " + request.Id);
            }

            tag.Title = request.Title;
            tag.SeoTitle = request.SeoTitle;
            tag.SeoDescription = request.SeoDescription;
        
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>();
        }

        public async Task<ApiResult<bool>> Delete(int id)
        {
            var tag = await _context.Tags.FindAsync(id);
        
            if (tag == null)
            {
                return new ApiErrorResult<bool>(SystemConstants.Message.CanNotFindIdMessage + "tag table with Id: " + id);
            }
            
            _context.Tags.Remove(tag);
            
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>();
        }
    }
}