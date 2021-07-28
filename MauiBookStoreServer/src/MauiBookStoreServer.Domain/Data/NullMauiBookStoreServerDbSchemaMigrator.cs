using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MauiBookStoreServer.Data
{
    /* This is used if database provider does't define
     * IMauiBookStoreServerDbSchemaMigrator implementation.
     */
    public class NullMauiBookStoreServerDbSchemaMigrator : IMauiBookStoreServerDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}