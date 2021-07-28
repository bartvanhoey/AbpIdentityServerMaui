using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MauiBookStoreServer.Data;
using Volo.Abp.DependencyInjection;

namespace MauiBookStoreServer.EntityFrameworkCore
{
    public class EntityFrameworkCoreMauiBookStoreServerDbSchemaMigrator
        : IMauiBookStoreServerDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMauiBookStoreServerDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the MauiBookStoreServerMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<MauiBookStoreServerMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}