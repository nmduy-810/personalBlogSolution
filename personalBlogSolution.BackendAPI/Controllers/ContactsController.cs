using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using personalBlogSolution.Services.Catalog.Contacts;
using personalBlogSolution.ViewModels.Catalog.Contact;

namespace personalBlogSolution.BackendAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }
        
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var contacts = await _contactService.GetAll();
            if (!contacts.IsSuccess)
            {
                return BadRequest(contacts);
            }
            return Ok(contacts.ResultDataObject);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ContactCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _contactService.Create(request);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ContactUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _contactService.Update(request);
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
            var result = await _contactService.Delete(id);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}