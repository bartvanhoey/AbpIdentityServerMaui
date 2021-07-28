using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MauiBookStoreServer.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class MauiBookStoreServerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MauiBookStoreServer";
    }
}
