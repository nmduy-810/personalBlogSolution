using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using personalBlogSolution.Data.EF;
using personalBlogSolution.Services.Catalog.Categories;

namespace personalBlogSolution.BackendAPI.Controllers
{
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categories;

        public CategoriesController(ICategoriesService categories)
        {
            _categories = categories;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll(string languageId)
        {
            var categories = await _categories.GetAll(languageId);
            if (!categories.IsSuccess)
            {
                return BadRequest(categories);
            }

            return Ok(categories.ResultDataObject);
        }

        [HttpGet("{id}/{languageId}")]
        public async Task<IActionResult> GetCategoryById(string languageId, int id)
        {
            var category = await _categories.GetCategoryById(languageId, id);
            
            if (!category.IsSuccess)
            {
                return BadRequest(category.ResultDataObject);
            }
            return Ok(category);
        }
    }
}