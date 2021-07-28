using MauiBookStoreServer.Localization;
using Volo.Abp.AspNetCore.Components;

namespace MauiBookStoreServer.Blazor
{
    public abstract class MauiBookStoreServerComponentBase : AbpComponentBase
    {
        protected MauiBookStoreServerComponentBase()
        {
            LocalizationResource = typeof(MauiBookStoreServerResource);
        }
    }
}
