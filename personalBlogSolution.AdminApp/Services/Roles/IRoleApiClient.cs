using System.Collections.Generic;
using System.Threading.Tasks;
using personalBlogSolution.ViewModels.Common.ApiResult;
using personalBlogSolution.ViewModels.System.Roles;

namespace personalBlogSolution.AdminApp.Services.Roles
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVM>>> GetAll();
    }
}