using System;
using System.Collections.Generic;

namespace personalBlogSolution.ViewModels.Catalog.Post
{
    public class PostVM
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string SeoTitle { get; set; }

        public int ViewCount { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public int? ParentId { get; set; }
        
        public string ThumbnailImage { get; set; }
        
        public List<string> Categories { get; set; } = new List<string>();
    }
}