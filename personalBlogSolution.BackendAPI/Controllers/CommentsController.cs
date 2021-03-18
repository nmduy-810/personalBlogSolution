using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using personalBlogSolution.Services.Catalog.Comments;
using personalBlogSolution.ViewModels.Catalog.Comment;

namespace personalBlogSolution.BackendAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var comments = await _commentService.GetAll();
            if (!comments.IsSuccess)
            {
                return BadRequest(comments);
            }
            return Ok(comments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentById(int id)
        {
            var comment = await _commentService.GetById(id);
            if (!comment.IsSuccess)
            {
                return BadRequest(comment);
            }
            return Ok(comment);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CommentCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _commentService.Create(request);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] CommentUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _commentService.Update(request);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _commentService.Delete(id);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}