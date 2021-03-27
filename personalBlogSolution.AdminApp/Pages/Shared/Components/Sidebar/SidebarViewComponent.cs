using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using personalBlogSolution.AdminApp.Models;
using personalBlogSolution.AdminApp.Services.Users;
using personalBlogSolution.Data.Entities;

namespace personalBlogSolution.AdminApp.Pages.Shared.Components.Sidebar
{
    [ViewComponent]
    public class SidebarViewComponent : ViewComponent
    {
        
        public SidebarViewComponent()
        { 
            
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentUserId = Request.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var sidebarVm = new SidebarViewModel()
            {
                UserId = currentUserId
            };
            
            return View("Default", sidebarVm);
        }
    }
}