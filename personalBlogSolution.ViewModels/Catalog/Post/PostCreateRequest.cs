using System;
using Microsoft.AspNetCore.Http;

namespace personalBlogSolution.ViewModels.Catalog.Post
{
    public class PostCreateRequest
    {
        public string Title { get; set; }
        
        public string Summary { get; set; }

        public string SeoTitle { get; set; }
        
        public IFormFile ThumbnailImage { get; set; }
        
        public Guid UserId { get; set; }
    }
}