using MauiBookStoreServer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MauiBookStoreServer.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MauiBookStoreServerController : AbpController
    {
        protected MauiBookStoreServerController()
        {
            LocalizationResource = typeof(MauiBookStoreServerResource);
        }
    }
}