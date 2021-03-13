using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using personalBlogSolution.Data.Entities;

namespace personalBlogSolution.Data.Configurations
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> modelBuilder)
        {
            modelBuilder.ToTable("AppRoles");

            modelBuilder.Property(x => x.Description).HasMaxLength(200).IsRequired();
        }
    }
}