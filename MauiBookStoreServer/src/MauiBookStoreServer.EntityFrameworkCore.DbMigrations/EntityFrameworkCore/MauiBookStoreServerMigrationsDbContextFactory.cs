using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MauiBookStoreServer.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class MauiBookStoreServerMigrationsDbContextFactory : IDesignTimeDbContextFactory<MauiBookStoreServerMigrationsDbContext>
    {
        public MauiBookStoreServerMigrationsDbContext CreateDbContext(string[] args)
        {
            MauiBookStoreServerEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MauiBookStoreServerMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new MauiBookStoreServerMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MauiBookStoreServer.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
