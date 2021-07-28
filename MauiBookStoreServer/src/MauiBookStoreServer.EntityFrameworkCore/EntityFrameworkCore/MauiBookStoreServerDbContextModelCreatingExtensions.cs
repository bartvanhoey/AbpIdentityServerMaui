using Microsoft.EntityFrameworkCore;
using Volo.Abp;

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
        }
    }
}