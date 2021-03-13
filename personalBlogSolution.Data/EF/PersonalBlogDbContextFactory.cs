using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace personalBlogSolution.Data.EF
{
    public class PersonalBlogDbContextFactory: IDesignTimeDbContextFactory<PersonalBlogDbContext>
    {
        public PersonalBlogDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configurationRoot.GetConnectionString("personalBlogSolutionDb");

            var optionBuilder = new DbContextOptionsBuilder<PersonalBlogDbContext>();

            optionBuilder.UseSqlServer(connectionString);

            return new PersonalBlogDbContext(optionBuilder.Options);
        }
    }
}