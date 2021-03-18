using System;
using System.Collections.Generic;

namespace personalBlogSolution.ViewModels.Catalog.Comment
{
    public class CommentVM
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public string Title { get; set; }
        
        public string Summary { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
        
        public string PostTitle { get; set; }

        public string PostSummary { get; set; }

        public int PostViewCount { get; set; }
        
    }
}