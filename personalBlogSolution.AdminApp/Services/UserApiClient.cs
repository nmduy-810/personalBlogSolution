using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using personalBlogSolution.ViewModels.Common.ApiResult;
using personalBlogSolution.ViewModels.Common.Paged;
using personalBlogSolution.ViewModels.System.Users;

namespace personalBlogSolution.AdminApp.Services
{
    public class UserApiClient: IUserApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserApiClient(IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
        }
        
        public async Task<ApiResult<string>> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.PostAsync("/api/users/authenticate", httpContent);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<string>>(await response.Content.ReadAsStringAsync());
            }

            return JsonConvert.DeserializeObject<ApiErrorResult<string>>(await response.Content.ReadAsStringAsync());
        }

        public Task<ApiResult<PagedResult<UserVM>>> GetUsersPaging(GetUserPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bool>> RegisterUser(UserRegisterRequest registerRequest)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<UserVM>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bool>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}