using System.Threading.Tasks;

namespace DevNas.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
