using Microsoft.AspNetCore.Mvc;

namespace personalBlogSolution.AdminApp.Controllers
{
    public class RoleController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}