using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using personalBlogSolution.ViewModels.Catalog.Post;
using personalBlogSolution.ViewModels.Common.ApiResult;

namespace personalBlogSolution.Services.Catalog.Posts
{
    public interface IPostService
    {
        Task<ApiResult<List<PostVM>>> GetAll();
        
        Task<ApiResult<PostVM>> GetById(int postId);
        
        Task<ApiResult<bool>> Create(PostCreateRequest request);
        
        Task<ApiResult<bool>> Update(PostUpdateRequest request);

        Task<ApiResult<bool>> Delete(int id);
        
        //Helper Methods
        Task<string> SaveFile(IFormFile file);
    }
}