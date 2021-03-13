using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using personalBlogSolution.Data.Entities;

namespace personalBlogSolution.Data.Configurations
{
    public class CommentConfiguration: IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");

            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Title).IsRequired().HasMaxLength(200);

            builder.Property(x => x.Summary).HasMaxLength(500);

            builder.Property(x => x.DateCreated).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.DateModified).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.ParentId).HasDefaultValue(1);

            builder.HasOne(x => x.Post).WithMany(x => x.Comments).HasForeignKey(x => x.PostId);

        }
    }
}