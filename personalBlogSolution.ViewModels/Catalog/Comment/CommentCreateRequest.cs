using System;

namespace personalBlogSolution.ViewModels.Catalog.Comment
{
    public class CommentCreateRequest
    {
        public int? ParentId { get; set; }

        public string Title { get; set; }
        
        public string Summary { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public int PostId { get; set; }
    }
}