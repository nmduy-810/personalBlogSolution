using personalBlogSolution.Data.Enums;

namespace personalBlogSolution.ViewModels.Catalog.Contact
{
    public class ContactUpdateRequest
    {
        public int Id { get; set; }
        
        public string Name { set; get; }
        
        public string Email { set; get; }
        
        public string PhoneNumber { set; get; }
        
        public string Message { set; get; }
        
        public Status Status { set; get; }
    }
}