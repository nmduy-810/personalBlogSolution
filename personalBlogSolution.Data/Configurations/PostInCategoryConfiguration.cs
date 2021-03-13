using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using personalBlogSolution.Data.Entities;

namespace personalBlogSolution.Data.Configurations
{
    public class PostInCategoryConfiguration: IEntityTypeConfiguration<PostInCategory>
    {
        public void Configure(EntityTypeBuilder<PostInCategory> builder)
        {
            builder.ToTable("PostInCategories");
            
            builder.HasKey(x => new {x.CategoryId, x.PostId});

            builder.HasOne(x => x.Post)
                .WithMany(x => x.PostInCategories).HasForeignKey(x => x.PostId);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.PostInCategories).HasForeignKey(x => x.CategoryId);
        }
    }
}