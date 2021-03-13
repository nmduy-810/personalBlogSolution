using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using personalBlogSolution.Data.Entities;
using personalBlogSolution.Data.Enums;

namespace personalBlogSolution.Data.Configurations
{
    public class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ParentId).HasDefaultValue(1);

            builder.Property(x => x.IsShowOnHome).HasDefaultValue(true);
            
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}