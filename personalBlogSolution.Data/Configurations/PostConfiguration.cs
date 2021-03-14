using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using personalBlogSolution.Data.Entities;

namespace personalBlogSolution.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");

            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Title).IsRequired().HasMaxLength(200);

            builder.Property(x => x.Summary).IsRequired();

            builder.Property(x => x.SeoTitle).HasMaxLength(200);

            builder.Property(x => x.ViewCount).HasDefaultValue(1);

            builder.Property(x => x.DateCreated).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.DateModified).HasDefaultValue(DateTime.Now);
        }
    }
}