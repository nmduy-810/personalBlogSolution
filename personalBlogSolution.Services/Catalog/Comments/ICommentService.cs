using System.Collections.Generic;
using System.Threading.Tasks;
using personalBlogSolution.ViewModels.Catalog.Comment;
using personalBlogSolution.ViewModels.Common.ApiResult;

namespace personalBlogSolution.Services.Catalog.Comments
{
    public interface ICommentService
    {
        Task<ApiResult<List<CommentVM>>> GetAll();

        Task<ApiResult<CommentVM>> GetById(int commentId);

        Task<ApiResult<bool>> Create(CommentCreateRequest request);

        Task<ApiResult<bool>> Update(CommentUpdateRequest request);

        Task<ApiResult<bool>> Delete(int commentId);
    }
}