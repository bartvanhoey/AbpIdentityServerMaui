using System.Threading.Tasks;

namespace MauiBookStoreServer.Data
{
    public interface IMauiBookStoreServerDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
