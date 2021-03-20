using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using personalBlogSolution.Data.EF;
using personalBlogSolution.ViewModels.Common.ApiResult;
using personalBlogSolution.ViewModels.System.Languages;

namespace personalBlogSolution.Services.System.Languages
{
    public class LanguageService: ILanguageService
    {
        private readonly PersonalBlogDbContext _context;
        private readonly IConfiguration _config;
        
        public LanguageService(PersonalBlogDbContext context,
            IConfiguration config)
        {
            _config = config;
            _context = context;
        }

        public async Task<ApiResult<List<LanguageVM>>> GetAll()
        {
            var languages = await _context.Languages.Select(x => new LanguageVM()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();

            return new ApiSuccessResult<List<LanguageVM>>(languages);
        }
    }
}