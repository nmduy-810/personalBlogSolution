using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using personalBlogSolution.Data.Entities;
using personalBlogSolution.Data.Enums;

namespace personalBlogSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            
            //Any Guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");

            //AppRole
            builder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = roleId,
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Administration role"
                }
            );

            //AppUser
            var hasher = new PasswordHasher<AppUser>();
            builder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "nguyenminhduy8101996@gmail.com",
                NormalizedEmail = "nguyenminhduy8101996@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Nguyen",
                LastName = "Duy",
                Dob = new DateTime(1996, 10, 08)
            });

            builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
            
            //Language
            builder.Entity<Language>().HasData(
                new Language() {Id = "vi", Name = "Tiếng Việt", IsDefault = true},
                new Language() {Id = "en", Name = "English", IsDefault = false});

            //Category
            builder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 3,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 3,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 4,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 4,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 5,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 5,
                    Status = Status.Active
                }
            );

            //CategoryTranslations
            builder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Tin tức công nghệ",
                    LanguageId = "vi",
                    SeoAlias = "tin-tuc-hay-ve-cong-nghe",
                    SeoDescription = "Các tin tức hay về công nghệ",
                    SeoTitle = "Các tin tức hay về công nghệ"
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Tech news",
                    LanguageId = "en",
                    SeoAlias = "Tech-news",
                    SeoDescription = "Tech-news",
                    SeoTitle = "Tech-news"
                },
                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Thủ thuật",
                    LanguageId = "vi",
                    SeoAlias = "Thủ thuật",
                    SeoDescription = "Cac-thu-thuat-hay-trong-lap-trinh",
                    SeoTitle = "Cac-thu-thuat-hay-trong-lap-trinh"
                },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Tricks",
                    LanguageId = "en",
                    SeoAlias = "good-tricks-in-programming",
                    SeoDescription = "Good tricks in programming",
                    SeoTitle = "Good tricks in programming"
                },
                new CategoryTranslation()
                {
                    Id = 5,
                    CategoryId = 3,
                    Name = "Lời khuyên",
                    LanguageId = "vi",
                    SeoAlias = "loi-khuyen-hay-ve-lap-trinh-cho-nguoi-moi-bat-dau",
                    SeoDescription = "Lời khuyên hay về lập trình cho người mới bắt đầu",
                    SeoTitle = "Lời khuyên hay về lập trình cho người mới bắt đầu"
                },
                new CategoryTranslation()
                {
                    Id = 6,
                    CategoryId = 3,
                    Name = "Beginner tips",
                    LanguageId = "en",
                    SeoAlias = "Beginner-tips-for-learning-programming",
                    SeoDescription = "Beginner tips for learning programming",
                    SeoTitle = "Beginner tips for learning programming"
                },
                new CategoryTranslation()
                {
                    Id = 7,
                    CategoryId = 4,
                    Name = "Liên hệ",
                    LanguageId = "vi",
                    SeoAlias = "Lien-he",
                    SeoDescription = "Liên hệ",
                    SeoTitle = "Liên hệ"
                },
                new CategoryTranslation()
                {
                    Id = 8,
                    CategoryId = 4,
                    Name = "Contact",
                    LanguageId = "en",
                    SeoAlias = "Contact",
                    SeoDescription = "Contact",
                    SeoTitle = "Contact"
                },
                new CategoryTranslation()
                {
                    Id = 9,
                    CategoryId = 5,
                    Name = "Thông tin",
                    LanguageId = "vi",
                    SeoAlias = "Thong-tin-ve-toi",
                    SeoDescription = "Thông tin về tôi",
                    SeoTitle = "Thông tin về tôi"
                },
                new CategoryTranslation()
                {
                    Id = 10,
                    CategoryId = 5,
                    Name = "About me",
                    LanguageId = "en",
                    SeoAlias = "About-me",
                    SeoDescription = "About me",
                    SeoTitle = "About me"
                }
            );

            //Posts
            builder.Entity<Post>().HasData(
                new Post()
                {
                    Id = 1,
                    Title = "11 Beginner Tips for Learning C# Programming",
                    Summary =
                        "We are so excited that you have decided to embark on the journey of learning C#! One of the most common questions we receive from our readers is “What’s the best way to learn C#?”",
                    SeoTitle = "11 Beginner Tips for Learning C# Programming",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    ParentId = null,
                    UserId = adminId
                },
                new Post()
                {
                    Id = 2,
                    Title = "What Is NullReferenceException? Object reference not set to an instance of an object",
                    Summary =
                        "Object Reference Not Set to an instance of an object.” Cast the first stone those who never struggled with this error message when they were a beginner C#/.NET programmer. This infamous and dreaded error message happens when you get a NullReferenceException.",
                    SeoTitle = "What Is NullReferenceException? Object reference not set to an instance of an object",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    ParentId = null,
                    UserId = adminId
                },
                new Post()
                {
                    Id = 3,
                    Title = "Bitcoin Crosses $60,000 for First Time",
                    Summary =
                        "Bitcoin briefly rose above $60,000 (roughly Rs. 43.7) for the first time on Saturday, as increasing backing from corporate heavyweights helps the world's most popular virtual currency continue its record-breaking run.",
                    SeoTitle = "Bitcoin Crosses $60,000 for First Time",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    ParentId = null,
                    UserId = adminId
                }
            );

            //PostInCategory
            builder.Entity<PostInCategory>().HasData(
                new PostInCategory()
                {
                    CategoryId = 3,
                    PostId = 1
                },
                new PostInCategory()
                {
                    CategoryId = 2,
                    PostId = 2
                },
                new PostInCategory()
                {
                    CategoryId = 1,
                    PostId = 3
                }
            );

            //PostInImage
            builder.Entity<PostImage>().HasData(
                new PostImage()
                {
                    Id = 1,
                    PostId = 3,
                    ImagePath = "https://2.pik.vn/2021ed9f9809-f598-49be-833a-a7bf6b827f91.jpg",
                    Caption = "Bitcoin",
                    DateCreated = DateTime.Now,
                    SortOrder = 1,
                    IsDefault = true
                },
                new PostImage()
                {
                    Id = 2,
                    PostId = 2,
                    ImagePath = "https://2.pik.vn/202187122db7-f2cb-4b43-ad1f-c770695a23b3.png",
                    Caption = "Object",
                    DateCreated = DateTime.Now,
                    SortOrder = 1,
                    IsDefault = true
                }
            );

            //PostInMeta
            builder.Entity<PostInMeta>().HasData(
                new PostInMeta()
                {
                    Id = 1,
                    PostId = 1,
                    Key = 1
                }
            );

            //Tag
            builder.Entity<Tag>().HasData(
                new Tag()
                {
                    Id = 1,
                    Title = "tricks",
                    SeoTitle = "tricks",
                    SeoDescription = "tricks",
                },
                new Tag()
                {
                    Id = 2,
                    Title = "tips",
                    SeoTitle = "tips",
                    SeoDescription = "tips",
                },
                new Tag()
                {
                    Id = 3,
                    Title = "developer-tips",
                    SeoTitle = "developer-tips",
                    SeoDescription = "developer-tips",
                },
                new Tag()
                {
                    Id = 4,
                    Title = "new-tricks",
                    SeoTitle = "new-tricks",
                    SeoDescription = "new-tricks",
                }
            );

            //PostInTag
            builder.Entity<PostInTag>().HasData(
                new PostInTag()
                {
                    PostId = 1,
                    TagId = 2
                },
                new PostInTag()
                {
                    PostId = 1,
                    TagId = 3
                },
                new PostInTag()
                {
                    PostId = 2,
                    TagId = 4
                }
            );

            //Contact
            builder.Entity<Contact>().HasData(
                new Contact()
                {
                    Id = 1,
                    Name = "Nguyễn Minh Duy",
                    Email = "nguyenminhduy8101996@gmail.com",
                    PhoneNumber = "0969772069",
                    Message = "Hãy liên hệ tôi nếu cần",
                    Status = Status.Active
                }
            );
        }
    }
}