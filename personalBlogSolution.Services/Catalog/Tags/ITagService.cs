using System.Collections.Generic;
using System.Threading.Tasks;
using personalBlogSolution.ViewModels.Catalog.Tag;
using personalBlogSolution.ViewModels.Common.ApiResult;

namespace personalBlogSolution.Services.Catalog.Tags
{
    public interface ITagService
    {
        Task<ApiResult<List<TagVM>>> GetAll();
        
        Task<ApiResult<bool>> Create(TagCreateRequest request);
        
        Task<ApiResult<bool>> Update(TagUpdateRequest request);
        
        Task<ApiResult<bool>> Delete(int id);
    }
}