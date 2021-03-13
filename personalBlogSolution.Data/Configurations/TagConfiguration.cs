using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using personalBlogSolution.Data.Entities;

namespace personalBlogSolution.Data.Configurations
{
    public class TagConfiguration: IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tags");

            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Title).HasMaxLength(200);

            builder.Property(x => x.SeoTitle).HasMaxLength(200);
            
            builder.Property(x => x.SeoDescription).HasMaxLength(500);

            builder.Property(x => x.ViewCount).HasDefaultValue(1);
        }
    }
}