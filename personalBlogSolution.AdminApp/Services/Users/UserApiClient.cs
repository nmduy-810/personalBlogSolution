using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using personalBlogSolution.ViewModels.Common.ApiResult;
using personalBlogSolution.ViewModels.Common.Paged;
using personalBlogSolution.ViewModels.System.Users;

namespace personalBlogSolution.AdminApp.Services.Users
{
    public class UserApiClient : BaseApiClient, IUserApiClient
    {
        public UserApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration) : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<string>> Authenticate(LoginRequest request)
        {
            return await PostAsync<ApiResult<string>>("/api/users/authenticate", request);
        }

        public async Task<ApiResult<bool>> DeleteUser(Guid id)
        {
            return await DeleteAsync<ApiResult<bool>>($"/api/users/{id}");
        }

        public async Task<ApiResult<UserVM>> GetById(Guid id)
        {
            return await GetAsync<ApiResult<UserVM>>($"/api/users/{id}");
        }

        public async Task<ApiResult<PagedResult<UserVM>>> GetUsersPaging(GetUserPagingRequest request)
        {
            return await GetAsync<ApiResult<PagedResult<UserVM>>>("/api/users/paging?pageIndex=" + $"{request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}");
        }

        public async Task<ApiResult<bool>> RegisterUser(UserRegisterRequest registerRequest)
        {
            return await PostAsync<ApiResult<bool>>("/api/users", registerRequest);
        }

        public async Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request)
        {
            return await PutAsync<ApiResult<bool>>($"/api/users/{id}/roles", request);
        }

        public async Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request)
        {
            return await PutAsync<ApiResult<bool>>($"/api/users/{id}", request);
        }
    }
}