using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using personalBlogSolution.AdminApp.Models;

namespace personalBlogSolution.AdminApp.Pages.Shared.Components.Topbar
{
    [ViewComponent]
    public class TopbarViewComponent : ViewComponent
    {
        public TopbarViewComponent()
        {
            
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var topbarVm = new TopbarViewModel()
            {

            };
            return View("Default", topbarVm);
        }
    }
}