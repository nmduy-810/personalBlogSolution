using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using personalBlogSolution.Data.Entities;

namespace personalBlogSolution.Data.Configurations
{
    public class PostImageConfiguration: IEntityTypeConfiguration<PostImage>
    {
        public void Configure(EntityTypeBuilder<PostImage> builder)
        {
            builder.ToTable("PostImages");
            
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ImagePath).HasMaxLength(200).IsRequired(true);
            
            builder.Property(x => x.Caption).HasMaxLength(200);

            builder.Property(x => x.DateCreated).HasDefaultValue(DateTime.Now);

            builder.HasOne(x => x.Post)
                .WithMany(x => x.PostImages).HasForeignKey(x => x.PostId);
        }
    }
}