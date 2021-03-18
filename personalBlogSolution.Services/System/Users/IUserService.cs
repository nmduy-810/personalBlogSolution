using System.Threading.Tasks;
using personalBlogSolution.ViewModels.Common.Paged;
using personalBlogSolution.ViewModels.System.Users;

namespace personalBlogSolution.Services.System.Users
{
    public interface IUserService
    {
        Task<PagedResult<UserVM>> GetUsersPaging(GetUserPagingRequest request);
        
        Task<bool> Register(RegisterRequest request);
        
        Task<string> Authenticate(LoginRequest request);
    }
}