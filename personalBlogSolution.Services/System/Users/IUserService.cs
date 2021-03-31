using System;
using System.Threading.Tasks;
using personalBlogSolution.ViewModels.Common.ApiResult;
using personalBlogSolution.ViewModels.Common.Paged;
using personalBlogSolution.ViewModels.System.Users;

namespace personalBlogSolution.Services.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<bool>> Register(UserRegisterRequest request);

        Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);
        
        Task<ApiResult<bool>> ChangePassword(Guid id, UserUpdatePasswordRequest request);

        Task<ApiResult<bool>> Delete(Guid id);

        Task<ApiResult<PagedResult<UserVM>>> GetUsersPaging(GetUserPagingRequest request);

        Task<ApiResult<UserVM>> GetById(Guid id);

        Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);
    }
}