using System;

namespace personalBlogSolution.ViewModels.System.Users
{
    public class UserUpdatePasswordRequest
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }
        
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        
    }
}