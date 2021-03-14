using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using personalBlogSolution.Services.Catalog.Post;
using personalBlogSolution.Services.Common;
using personalBlogSolution.ViewModels.Catalog.Post;

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

        [HttpGet("get-post-by-id")]
        public async Task<IActionResult> GetPostById(int postId)
        {
            var post = await _postService.GetById(postId);
            if (post == null)
            {
                return BadRequest("Cannot find post");
            }

            return Ok(post);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] PostCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var post = await _postService.Create(request);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] PostUpdateRequest request)
        {
            var affectedResult = await _postService.Update(request);
            if (affectedResult == 0)
            {
                return BadRequest("Cannot find post");
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var affectedResult = await _postService.Delete(id);

            if (affectedResult == 0)
            {
                return BadRequest();
            }

            return Ok();
        }
        
    }
}