using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using personalBlogSolution.Data.Entities;

namespace personalBlogSolution.Data.Configurations
{
    public class PostInMetaConfiguration: IEntityTypeConfiguration<PostInMeta>
    {
        public void Configure(EntityTypeBuilder<PostInMeta> builder)
        {
            builder.ToTable("PostInMetas");

            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.Post)
                .WithMany(x => x.PostInMetas).HasForeignKey(x => x.PostId);
        }
    }
}