using MauiBookStoreServer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MauiBookStoreServer
{
    [DependsOn(
        typeof(MauiBookStoreServerEntityFrameworkCoreTestModule)
        )]
    public class MauiBookStoreServerDomainTestModule : AbpModule
    {

    }
}