namespace personalBlogSolution.Data.Entities
{
    public class PostInMeta
    {
        public int Id { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public int Key { get; set; }
    }
}