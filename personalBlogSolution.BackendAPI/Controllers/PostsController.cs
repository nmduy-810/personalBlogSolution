using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using personalBlogSolution.Services.Catalog.Post;
using personalBlogSolution.Services.Common;

namespace personalBlogSolution.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        private readonly IPostService _postService;
        private readonly IStorageService _storageService;
        
        public PostsController(IPostService postService, IStorageService storageService)
        {
            _postService = postService;
            _storageService = storageService;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> Get()
        {
            var posts = await _postService.GetAll();
            return Ok(posts);
        }
    }
}