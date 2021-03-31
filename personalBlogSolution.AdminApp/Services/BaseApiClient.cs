using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using personalBlogSolution.Utilities.Constants;

namespace personalBlogSolution.AdminApp.Services
{
    public class BaseApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        protected readonly IHttpContextAccessor _httpContextAccessor;
        
        protected BaseApiClient(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
        }

        protected async Task<TResponse> GetAsync<TResponse>(string url)
        {
            if (_httpContextAccessor.HttpContext == null) return JsonConvert.DeserializeObject<TResponse>(null);
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.Token);
            
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
                
            var response = await client.GetAsync(url);
                
            var body = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TResponse>(body);
            }
            
            var myDeserializedObjList = (TResponse)JsonConvert.DeserializeObject(body, typeof(TResponse));
            
            return myDeserializedObjList;
        }

        protected async Task<TResponse> PostAsync<TResponse>(string url, object request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);

            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, httpContent);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<TResponse>(result);
            return JsonConvert.DeserializeObject<TResponse>(result);
        }

        protected async Task<TResponse> PutAsync<TResponse>(string url, object request)
        {
            if (_httpContextAccessor.HttpContext == null) return JsonConvert.DeserializeObject<TResponse>(null);
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.Token);
            
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            
            var json = JsonConvert.SerializeObject(request);
            
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            
            var response = await client.PutAsync(url, httpContent);
            var result = await response.Content.ReadAsStringAsync();
            
            return JsonConvert.DeserializeObject<TResponse>(result);
        }

        protected async Task<TResponse> DeleteAsync<TResponse>(string url)
        {
            if (_httpContextAccessor.HttpContext == null) return JsonConvert.DeserializeObject<TResponse>(null);
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.Token);
            
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            
            var response = await client.DeleteAsync(url);
            
            var body = await response.Content.ReadAsStringAsync();
            
            return JsonConvert.DeserializeObject<TResponse>(body);
        }
    }
}