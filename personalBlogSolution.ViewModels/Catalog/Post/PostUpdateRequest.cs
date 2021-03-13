using Microsoft.AspNetCore.Http;

namespace personalBlogSolution.ViewModels.Catalog.Post
{
    public class PostUpdateRequest
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        public string Summary { get; set; }

        public string SeoTitle { get; set; }
        
        public IFormFile ThumbnailImage { get; set; }
    }
}