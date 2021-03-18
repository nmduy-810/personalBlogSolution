using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using personalBlogSolution.Services.Catalog.Posts;
using personalBlogSolution.Services.Common;
using personalBlogSolution.ViewModels.Catalog.Post;

namespace personalBlogSolution.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
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
            if (!posts.IsSuccess)
            {
                return BadRequest(posts);
            }
            return Ok(posts.ResultDataObject);
        }

        [HttpGet("get-post-by-id")]
        public async Task<IActionResult> GetPostById(int postId)
        {
            var post = await _postService.GetById(postId);
            if (!post.IsSuccess)
            {
                return BadRequest(post);
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

            var result = await _postService.Create(request);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] PostUpdateRequest request)
        {
            var result = await _postService.Update(request);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _postService.Delete(id);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}