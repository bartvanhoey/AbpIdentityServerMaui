using System;
using System.Collections.Generic;
using System.Text;
using MauiBookStoreServer.Localization;
using Volo.Abp.Application.Services;

namespace MauiBookStoreServer
{
    /* Inherit your application services from this class.
     */
    public abstract class MauiBookStoreServerAppService : ApplicationService
    {
        protected MauiBookStoreServerAppService()
        {
            LocalizationResource = typeof(MauiBookStoreServerResource);
        }
    }
}
