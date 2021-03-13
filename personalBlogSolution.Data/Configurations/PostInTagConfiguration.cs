using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using personalBlogSolution.Data.Entities;

namespace personalBlogSolution.Data.Configurations
{
    public class PostInTagConfiguration: IEntityTypeConfiguration<PostInTag>
    {
        public void Configure(EntityTypeBuilder<PostInTag> builder)
        {
            builder.ToTable("PostInTags");

            builder.HasKey(x => new {x.PostId, x.TagId});

            builder.HasOne(x => x.Post)
                .WithMany(x => x.PostInTags).HasForeignKey(x => x.PostId);

            builder.HasOne(x => x.Tag)
                .WithMany(x => x.PostInTags).HasForeignKey(x => x.TagId);
        }
    }
}