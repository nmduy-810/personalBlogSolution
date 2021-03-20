using System.Collections.Generic;
using System.Threading.Tasks;
using personalBlogSolution.ViewModels.Common.ApiResult;
using personalBlogSolution.ViewModels.System.Languages;

namespace personalBlogSolution.Services.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVM>>> GetAll();
    }
}