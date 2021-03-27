using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace personalBlogSolution.ViewModels.System.Users
{
    public class UserVM
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
        
        public DateTime Dob { get; set; }
        
        public IList<string> Roles { get; set; }
    }
}