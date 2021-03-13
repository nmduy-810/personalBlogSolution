using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using personalBlogSolution.Data.Configurations;
using personalBlogSolution.Data.Entities;
using personalBlogSolution.Data.Extensions;

namespace personalBlogSolution.Data.EF
{
    public class PersonalBlogDbContext: IdentityDbContext<AppUser, AppRole, Guid>
    {
        public PersonalBlogDbContext(DbContextOptions<PersonalBlogDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Configure using Fluent API
            builder.ApplyConfiguration(new AppConfigConfiguration());
            builder.ApplyConfiguration(new AppRoleConfiguration());
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new ContactConfiguration());
            builder.ApplyConfiguration(new LanguageConfiguration());
            builder.ApplyConfiguration(new PostConfiguration());
            builder.ApplyConfiguration(new PostImageConfiguration());
            builder.ApplyConfiguration(new PostInCategoryConfiguration());
            builder.ApplyConfiguration(new PostInMetaConfiguration());
            builder.ApplyConfiguration(new PostInTagConfiguration());
            builder.ApplyConfiguration(new SlideConfiguration());
            builder.ApplyConfiguration(new TagConfiguration());
            
            //Configure Identity
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId); 
            
            //Data Seeding
            builder.Seed();
        }
        
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<PostInCategory> PostInCategories { get; set; }
        public DbSet<PostInMeta> PostInMetas { get; set; }
        public DbSet<PostInTag> PostInTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}