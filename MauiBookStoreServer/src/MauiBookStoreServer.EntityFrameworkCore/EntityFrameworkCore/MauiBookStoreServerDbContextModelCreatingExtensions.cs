using MauiBookStoreServer.Domain.Books;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MauiBookStoreServer.EntityFrameworkCore
{
    public static class MauiBookStoreServerDbContextModelCreatingExtensions
    {
        public static void ConfigureMauiBookStoreServer(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MauiBookStoreServerConsts.DbTablePrefix + "YourEntities", MauiBookStoreServerConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<Book>(b =>
            {
                b.ToTable(MauiBookStoreServerConsts.DbTablePrefix + "Books", MauiBookStoreServerConsts.DbSchema);
                b.ConfigureByConvention();
            
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
        }
    }
}