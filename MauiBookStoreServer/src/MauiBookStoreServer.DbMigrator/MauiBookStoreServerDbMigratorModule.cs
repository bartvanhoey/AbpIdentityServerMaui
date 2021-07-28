using MauiBookStoreServer.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MauiBookStoreServer.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MauiBookStoreServerEntityFrameworkCoreDbMigrationsModule),
        typeof(MauiBookStoreServerApplicationContractsModule)
        )]
    public class MauiBookStoreServerDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
