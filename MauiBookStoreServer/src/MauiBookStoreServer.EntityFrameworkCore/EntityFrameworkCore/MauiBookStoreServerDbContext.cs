﻿using Microsoft.EntityFrameworkCore;
using MauiBookStoreServer.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;
using MauiBookStoreServer.Domain.Books;

namespace MauiBookStoreServer.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See MauiBookStoreServerMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class MauiBookStoreServerDbContext : AbpDbContext<MauiBookStoreServerDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside MauiBookStoreServerDbContextModelCreatingExtensions.ConfigureMauiBookStoreServer
         */
         public DbSet<Book> Books { get; set; }

        public MauiBookStoreServerDbContext(DbContextOptions<MauiBookStoreServerDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the MauiBookStoreServerEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureMauiBookStoreServer method */

            builder.ConfigureMauiBookStoreServer();
        }
    }
}
