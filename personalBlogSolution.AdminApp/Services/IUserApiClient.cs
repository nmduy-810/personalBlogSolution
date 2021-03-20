using System;
using System.Threading.Tasks;
using personalBlogSolution.ViewModels.Common.ApiResult;
using personalBlogSolution.ViewModels.Common.Paged;
using personalBlogSolution.ViewModels.System.Users;

namespace personalBlogSolution.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<PagedResult<UserVM>>> GetUsersPaging(GetUserPagingRequest request);

        Task<ApiResult<bool>> RegisterUser(UserRegisterRequest registerRequest);

        Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request);

        Task<ApiResult<UserVM>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);
        
    }
}