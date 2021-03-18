using System.Collections.Generic;
using System.Threading.Tasks;
using personalBlogSolution.ViewModels.Catalog.Category;
using personalBlogSolution.ViewModels.Common.ApiResult;

namespace personalBlogSolution.Services.Catalog.Categories
{
    public interface ICategoriesService
    {
        Task<ApiResult<List<CategoryVM>>> GetAll(string languageId);
    }
}