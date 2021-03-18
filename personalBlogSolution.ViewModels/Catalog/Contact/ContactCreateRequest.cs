using personalBlogSolution.Data.Enums;

namespace personalBlogSolution.ViewModels.Catalog.Contact
{
    public class ContactCreateRequest
    {
        public string Name { set; get; }
        
        public string Email { set; get; }
        
        public string PhoneNumber { set; get; }
        
        public string Message { set; get; }
    }
}