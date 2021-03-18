using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using personalBlogSolution.Data.EF;
using personalBlogSolution.Utilities.Constants;
using personalBlogSolution.ViewModels.Catalog.Category;
using personalBlogSolution.ViewModels.Common.ApiResult;
using NotImplementedException = System.NotImplementedException;

namespace personalBlogSolution.Services.Catalog.Categories
{
    public class CategoriesService: ICategoriesService
    {
        private readonly PersonalBlogDbContext _context;

        public CategoriesService(PersonalBlogDbContext context)
        {
            _context = context;
        }
        
        public async Task<ApiResult<List<CategoryVM>>> GetAll(string languageId)
        {
            var query = from c in _context.Categories
                join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                where ct.LanguageId == languageId
                select new { c, ct };

            var data = await query.Select(item => new CategoryVM()
            {
                Id = item.c.Id,
                Name = item.ct.Name,
                SeoTitle = item.ct.SeoTitle,
                SeoDescription = item.ct.SeoDescription,
                SeoAlias = item.ct.SeoAlias
                
            }).ToListAsync();

            return data == null ? new ApiErrorResult<List<CategoryVM>>(SystemConstants.NotFoundDataMessage) : new ApiSuccessResult<List<CategoryVM>>(data);
        }
    }
}