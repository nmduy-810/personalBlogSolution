using System;
using System.Collections.Generic;
using personalBlogSolution.ViewModels.Common.Others;

namespace personalBlogSolution.ViewModels.System.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }

        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}