using System.Collections.Generic;
using System.Threading.Tasks;
using personalBlogSolution.ViewModels.Catalog.Contact;
using personalBlogSolution.ViewModels.Common.ApiResult;

namespace personalBlogSolution.Services.Catalog.Contacts
{
    public interface IContactService
    {
        Task<ApiResult<List<ContactVM>>> GetAll();
        
        Task<ApiResult<bool>> Create(ContactCreateRequest request);
        
        Task<ApiResult<bool>> Update(ContactUpdateRequest request);
        
        Task<ApiResult<bool>> Delete(int id);
    }
}