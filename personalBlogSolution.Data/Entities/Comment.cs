using System;

namespace personalBlogSolution.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public string Title { get; set; }
        
        public string Summary { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}