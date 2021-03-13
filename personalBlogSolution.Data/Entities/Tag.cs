using System.Collections.Generic;

namespace personalBlogSolution.Data.Entities
{
    public class Tag
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string SeoTitle { get; set; }

        public string SeoDescription { get; set; }

        public int ViewCount { get; set; }

        //n-n
        public List<PostInTag> PostInTags { get; set; }
    }
}