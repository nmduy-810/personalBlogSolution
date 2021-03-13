using System;

namespace personalBlogSolution.Data.Entities
{
    public class PostImage
    {
        public int Id { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public string ImagePath { get; set; }

        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public DateTime DateCreated { get; set; }

        public int SortOrder { get; set; }

        public long FileSize { get; set; }
    }
}