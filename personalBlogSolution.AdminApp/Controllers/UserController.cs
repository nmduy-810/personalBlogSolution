using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using personalBlogSolution.AdminApp.Services.Roles;
using personalBlogSolution.AdminApp.Services.Users;
using personalBlogSolution.ViewModels.Common.Others;
using personalBlogSolution.ViewModels.System.Users;

namespace personalBlogSolution.AdminApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _configuration;
        private readonly IRoleApiClient _roleApiClient;
        
        public UserController(IUserApiClient userApiClient, IConfiguration configuration, IRoleApiClient roleApiClient)
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
            _roleApiClient = roleApiClient;
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
        
        [HttpGet]
        public async Task<IActionResult> RoleAssign(Guid id)
        {
            var roleAssignRequest = await GetRoleAssignRequest(id);
            return View(roleAssignRequest);
        }

        public async Task<IActionResult> RoleAssign(RoleAssignRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _userApiClient.RoleAssign(request.Id, request);

            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            var roleAssignRequest = await GetRoleAssignRequest(request.Id);

            return View(roleAssignRequest);
        }
        
        [HttpGet]
        public async Task<IActionResult> ChangePassword(Guid id)
        {
            var result = await _userApiClient.GetById(id);
            if (!result.IsSuccess) return RedirectToAction("Error", "Home");
            
            var user = result.ResultDataObject;
            var updatePasswordRequest = new UserUpdatePasswordRequest()
            {
                Id = id,
                UserName = user.UserName
            };
            return View(updatePasswordRequest);
        }
        
        [HttpPost]
        public async Task<IActionResult> ChangePassword(UserUpdatePasswordRequest request)
        {
            var result = await _userApiClient.ChangePassword(request.Id, request);
            return !result.IsSuccess ? RedirectToAction("Error", "Home") : RedirectToAction("Index", "Login");
        }
        
        //Helper Methods
        private async Task<RoleAssignRequest> GetRoleAssignRequest(Guid id)
        {
            var userObj = await _userApiClient.GetById(id);
            var roleObj = await _roleApiClient.GetAll();
            var roleAssignRequest = new RoleAssignRequest();
            foreach (var role in roleObj.ResultDataObject)
            {
                roleAssignRequest.Roles.Add(new SelectItem()
                {
                    Id = role.Id.ToString(),
                    Name = role.Name,
                    Selected = userObj.ResultDataObject.Roles.Contains(role.Name)
                });
            }
            return roleAssignRequest;
        }
    }
}