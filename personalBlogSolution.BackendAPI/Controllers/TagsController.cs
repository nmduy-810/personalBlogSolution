using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using personalBlogSolution.Services.Catalog.Tags;
using personalBlogSolution.ViewModels.Catalog.Tag;

namespace personalBlogSolution.BackendAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class TagsController : Controller
    {
        private readonly ITagService _tagService;

        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }
        
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var tags = await _tagService.GetAll();
            if (!tags.IsSuccess)
            {
                return BadRequest(tags);
            }
            return Ok(tags.ResultDataObject);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] TagCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _tagService.Create(request);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] TagUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _tagService.Update(request);
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
            var result = await _tagService.Delete(id);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        
    }
}