using System.Collections.Generic;
using System.Threading.Tasks;
using personalBlogSolution.ViewModels.System.Roles;

namespace personalBlogSolution.Services.System.Roles
{
    public interface IRoleService
    {
        Task<List<RoleVM>> GetAll();
    }
}