using System;
using System.Collections.Generic;

namespace personalBlogSolution.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string SeoTitle { get; set; }

        public int ViewCount { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public int? ParentId { get; set; }
        
        public List<PostInCategory> PostInCategories { get; set; }
        
        public List<PostInTag> PostInTags { get; set; }
        
        public List<Comment> Comments { get; set; }
        
        public List<PostImage> PostImages { get; set; }

        public List<PostInMeta> PostInMetas { get; set; }
    }
}