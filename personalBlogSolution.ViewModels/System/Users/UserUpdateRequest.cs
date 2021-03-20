using System;

namespace personalBlogSolution.ViewModels.System.Users
{
    public class UserUpdateRequest
    {
        public Guid Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public DateTime Dob { get; set; }
        
        public string Email { get; set; }
        
        public string PhoneNumber { get; set; }
    }
}