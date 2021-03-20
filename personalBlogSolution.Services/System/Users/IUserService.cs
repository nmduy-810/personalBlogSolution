using System.Threading.Tasks;
using personalBlogSolution.ViewModels.Common.ApiResult;
using personalBlogSolution.ViewModels.Common.Paged;
using personalBlogSolution.ViewModels.System.Users;

namespace personalBlogSolution.Services.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<PagedResult<UserVM>>> GetUsersPaging(GetUserPagingRequest request);
        
        Task<ApiResult<bool>> Register(UserRegisterRequest request);
        
        Task<ApiResult<string>> Authenticate(LoginRequest request);
    }
}