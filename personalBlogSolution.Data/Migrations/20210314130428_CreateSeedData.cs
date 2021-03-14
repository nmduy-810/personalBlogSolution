using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace personalBlogSolution.Data.Migrations
{
    public partial class CreateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 14, 20, 4, 27, 208, DateTimeKind.Local).AddTicks(4500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 14, 20, 2, 45, 577, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 14, 20, 4, 27, 208, DateTimeKind.Local).AddTicks(4200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 14, 20, 2, 45, 577, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "PostImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 14, 20, 4, 27, 209, DateTimeKind.Local).AddTicks(5750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 14, 20, 2, 45, 578, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 14, 20, 4, 27, 201, DateTimeKind.Local).AddTicks(3960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 14, 20, 2, 45, 570, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 14, 20, 4, 27, 189, DateTimeKind.Local).AddTicks(9790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 14, 20, 2, 45, 559, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "bbcbdf78-ef36-4472-8d27-fb13b7f95199", "Administration role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "1717269d-4167-4442-ad5f-890b78a31e3b", new DateTime(1996, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenminhduy8101996@gmail.com", true, "Nguyen", "Duy", false, null, "nguyenminhduy8101996@gmail.com", "admin", "AQAAAAEAACcQAAAAEDVqYxRhPPavLuVHKI0zmsUECwZ9ta4y93zZQcUFw/CT0o0gufqtmrvgzeSdWTK/Aw==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, 1, 1 },
                    { 2, true, 2, 1 },
                    { 3, true, 3, 1 },
                    { 4, true, 4, 1 },
                    { 5, true, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "Message", "Name", "PhoneNumber", "Status" },
                values: new object[] { 1, "nguyenminhduy8101996@gmail.com", "Hãy liên hệ tôi nếu cần", "Nguyễn Minh Duy", "0969772069", 1 });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi", true, "Tiếng Việt" },
                    { "en", false, "English" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "DateCreated", "DateModified", "ParentId", "SeoTitle", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 3, 14, 20, 4, 27, 254, DateTimeKind.Local).AddTicks(250), new DateTime(2021, 3, 14, 20, 4, 27, 254, DateTimeKind.Local).AddTicks(700), null, "11 Beginner Tips for Learning C# Programming", "We are so excited that you have decided to embark on the journey of learning C#! One of the most common questions we receive from our readers is “What’s the best way to learn C#?”", "11 Beginner Tips for Learning C# Programming" },
                    { 2, new DateTime(2021, 3, 14, 20, 4, 27, 254, DateTimeKind.Local).AddTicks(1560), new DateTime(2021, 3, 14, 20, 4, 27, 254, DateTimeKind.Local).AddTicks(1570), null, "What Is NullReferenceException? Object reference not set to an instance of an object", "Object Reference Not Set to an instance of an object.” Cast the first stone those who never struggled with this error message when they were a beginner C#/.NET programmer. This infamous and dreaded error message happens when you get a NullReferenceException.", "What Is NullReferenceException? Object reference not set to an instance of an object" },
                    { 3, new DateTime(2021, 3, 14, 20, 4, 27, 254, DateTimeKind.Local).AddTicks(1570), new DateTime(2021, 3, 14, 20, 4, 27, 254, DateTimeKind.Local).AddTicks(1570), null, "Bitcoin Crosses $60,000 for First Time", "Bitcoin briefly rose above $60,000 (roughly Rs. 43.7) for the first time on Saturday, as increasing backing from corporate heavyweights helps the world's most popular virtual currency continue its record-breaking run.", "Bitcoin Crosses $60,000 for First Time" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "SeoDescription", "SeoTitle", "Title" },
                values: new object[,]
                {
                    { 1, "tricks", "tricks", "tricks" },
                    { 2, "tips", "tips", "tips" },
                    { 3, "developer-tips", "developer-tips", "developer-tips" },
                    { 4, "new-tricks", "new-tricks", "new-tricks" }
                });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "vi", "Tin tức công nghệ", "tin-tuc-hay-ve-cong-nghe", "Các tin tức hay về công nghệ", "Các tin tức hay về công nghệ" },
                    { 8, 4, "en", "Contact", "Contact", "Contact", "Contact" },
                    { 6, 3, "en", "Beginner tips", "Beginner-tips-for-learning-programming", "Beginner tips for learning programming", "Beginner tips for learning programming" },
                    { 4, 2, "en", "Tricks", "good-tricks-in-programming", "Good tricks in programming", "Good tricks in programming" },
                    { 2, 1, "en", "Tech news", "Tech-news", "Tech-news", "Tech-news" },
                    { 10, 5, "en", "About me", "About-me", "About me", "About me" },
                    { 7, 4, "vi", "Liên hệ", "Lien-he", "Liên hệ", "Liên hệ" },
                    { 5, 3, "vi", "Lời khuyên", "loi-khuyen-hay-ve-lap-trinh-cho-nguoi-moi-bat-dau", "Lời khuyên hay về lập trình cho người mới bắt đầu", "Lời khuyên hay về lập trình cho người mới bắt đầu" },
                    { 3, 2, "vi", "Thủ thuật", "Thủ thuật", "Cac-thu-thuat-hay-trong-lap-trinh", "Cac-thu-thuat-hay-trong-lap-trinh" },
                    { 9, 5, "vi", "Thông tin", "Thong-tin-ve-toi", "Thông tin về tôi", "Thông tin về tôi" }
                });

            migrationBuilder.InsertData(
                table: "PostImages",
                columns: new[] { "Id", "Caption", "DateCreated", "FileSize", "ImagePath", "IsDefault", "PostId", "SortOrder" },
                values: new object[,]
                {
                    { 2, "Object", new DateTime(2021, 3, 14, 20, 4, 27, 254, DateTimeKind.Local).AddTicks(6290), 0L, "https://2.pik.vn/202187122db7-f2cb-4b43-ad1f-c770695a23b3.png", true, 2, 1 },
                    { 1, "Bitcoin", new DateTime(2021, 3, 14, 20, 4, 27, 254, DateTimeKind.Local).AddTicks(5120), 0L, "https://2.pik.vn/2021ed9f9809-f598-49be-833a-a7bf6b827f91.jpg", true, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "PostInCategories",
                columns: new[] { "CategoryId", "PostId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 2, 2 },
                    { 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "PostInMetas",
                columns: new[] { "Id", "Key", "PostId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "PostInTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 2 },
                    { 2, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostInCategories",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PostInCategories",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PostInCategories",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "PostInMetas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostInTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PostInTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PostInTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 14, 20, 2, 45, 577, DateTimeKind.Local).AddTicks(380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 14, 20, 4, 27, 208, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 14, 20, 2, 45, 577, DateTimeKind.Local).AddTicks(80),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 14, 20, 4, 27, 208, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "PostImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 14, 20, 2, 45, 578, DateTimeKind.Local).AddTicks(1850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 14, 20, 4, 27, 209, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 14, 20, 2, 45, 570, DateTimeKind.Local).AddTicks(4370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 14, 20, 4, 27, 201, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 14, 20, 2, 45, 559, DateTimeKind.Local).AddTicks(5570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 14, 20, 4, 27, 189, DateTimeKind.Local).AddTicks(9790));
        }
    }
}
