using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace personalBlogSolution.Data.Entities
{
    public class AppUser: IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }
    }
}