using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using personalBlogSolution.Services.System.Users;
using personalBlogSolution.ViewModels.System.Users;

namespace personalBlogSolution.BackendAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService; 
        
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet("paging")]
        public async Task<IActionResult> GetAllUsersPaging([FromQuery] GetUserPagingRequest request)
        {
            var users = await _userService.GetUsersPaging(request);
            return Ok(users);
        }
        
        [HttpPost("register")]
        
        public async Task<IActionResult> Register([FromForm] UserRegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _userService.Register(request);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Authenticate(request);

            if (string.IsNullOrEmpty(result.ResultDataObject))
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}