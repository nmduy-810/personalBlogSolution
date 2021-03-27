using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using personalBlogSolution.AdminApp.Services.Users;
using personalBlogSolution.Data.Entities;
using personalBlogSolution.ViewModels.System.Users;

namespace personalBlogSolution.AdminApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _configuration;
       
        //private readonly IRoleApiClient _roleApiClient;
        
        public UserController(IUserApiClient userApiClient, IConfiguration configuration)
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
            //_roleApiClient = roleApiClient;
        }
        
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetUserPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            
            var data = await _userApiClient.GetUsersPaging(request);
            return View(data.ResultDataObject);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserRegisterRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _userApiClient.RegisterUser(request);
            if (result.IsSuccess)
            {
                
                return RedirectToAction("Index");
            }
            
            ModelState.AddModelError("", result.Message);
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var result = await _userApiClient.GetById(id);
            if (!result.IsSuccess) return RedirectToAction("Error", "Home");
            
            var user = result.ResultDataObject;
            var updateRequest = new UserUpdateRequest()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Dob = user.Dob,
                Id = id
            };
            return View(updateRequest);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _userApiClient.UpdateUser(request.Id, request);
            if (!result.IsSuccess) return View(request);

            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _userApiClient.DeleteUser(id);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var result = await _userApiClient.GetById(id);
            return View(result.ResultDataObject);
        }
        
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            return RedirectToAction("Index", "Login");
        }

        // public async Task<IActionResult> ChangePassword(UserUpdateRequest request)
        // {
        //     
        // }
    }
}