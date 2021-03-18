namespace personalBlogSolution.ViewModels.Catalog.Tag
{
    public class TagUpdateRequest
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        public string SeoTitle { get; set; }

        public string SeoDescription { get; set; }
    }
}