using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace MauiBookStoreServer.EntityFrameworkCore
{
    [DependsOn(
        typeof(MauiBookStoreServerEntityFrameworkCoreModule)
        )]
    public class MauiBookStoreServerEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MauiBookStoreServerMigrationsDbContext>();
        }
    }
}
