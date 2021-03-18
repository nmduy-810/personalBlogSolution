using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using personalBlogSolution.Data.EF;
using personalBlogSolution.Data.Entities;
using personalBlogSolution.Utilities.Constants;
using personalBlogSolution.ViewModels.Catalog.Contact;
using personalBlogSolution.ViewModels.Common.ApiResult;

namespace personalBlogSolution.Services.Catalog.Contacts
{
    public class ContactService: IContactService
    {
        private readonly PersonalBlogDbContext _context;
        
        public ContactService(PersonalBlogDbContext context)
        {
            _context = context;
        }
        
        public async Task<ApiResult<List<ContactVM>>> GetAll()
        {
            var query = from c in _context.Contacts select c;
        
            var data = await query.Select(item => new ContactVM()
            {
                Name = item.Name,
                Email = item.Email,
                PhoneNumber = item.PhoneNumber,
                Message = item.Message,
                Status = item.Status
            }).ToListAsync();
        
            return data == null ? new ApiErrorResult<List<ContactVM>>(SystemConstants.NotFoundDataMessage) : new ApiSuccessResult<List<ContactVM>>(data);
        }
        
        public async Task<ApiResult<bool>> Create(ContactCreateRequest request)
        {
            var contact = new Contact()
            {
                Name = request.Name,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Message = request.Message
            };
        
            var result = await _context.Contacts.AddAsync(contact);
        
            await _context.SaveChangesAsync();
        
            return result == null
                ? new ApiErrorResult<bool>("Contact data can't create")
                : new ApiSuccessResult<bool>(SystemConstants.SuccessfulDataCreate);
        }
        
        public async Task<ApiResult<bool>> Update(ContactUpdateRequest request)
        {
            var contact = await _context.Contacts.FindAsync(request.Id);
        
            if (contact == null)
            {
                return new ApiErrorResult<bool>(SystemConstants.CanNotFindIdMessage + "comment table with Id: " + request.Id);
            }
        
            contact.Name = request.Name;
            contact.Message = request.Message;
            contact.Email = request.Email;
            contact.PhoneNumber = request.PhoneNumber;
            contact.Status = request.Status;
        
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>(SystemConstants.SuccessfulDataUpdate);
        }
        
        public async Task<ApiResult<bool>> Delete(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
        
            if (contact == null)
            {
                return new ApiErrorResult<bool>(SystemConstants.CanNotFindIdMessage + "contact table with Id: " + id);
            }
            
            _context.Contacts.Remove(contact);
            
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>(SystemConstants.SuccessfulDataDelete);
        }
    }
}