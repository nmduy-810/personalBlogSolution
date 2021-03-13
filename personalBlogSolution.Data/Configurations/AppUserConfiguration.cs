using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using personalBlogSolution.Data.Entities;

namespace personalBlogSolution.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> modelBuilder)
        {
            modelBuilder.ToTable("AppUsers");

            modelBuilder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);

            modelBuilder.Property(x => x.LastName).IsRequired().HasMaxLength(200);

            modelBuilder.Property(x => x.Dob).IsRequired();
        }
    }
}