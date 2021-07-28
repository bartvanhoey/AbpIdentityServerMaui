using Volo.Abp.Modularity;

namespace MauiBookStoreServer
{
    [DependsOn(
        typeof(MauiBookStoreServerApplicationModule),
        typeof(MauiBookStoreServerDomainTestModule)
        )]
    public class MauiBookStoreServerApplicationTestModule : AbpModule
    {

    }
}