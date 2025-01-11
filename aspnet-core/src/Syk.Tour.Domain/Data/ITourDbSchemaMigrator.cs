using System.Threading.Tasks;

namespace Syk.Tour.Data;

public interface ITourDbSchemaMigrator
{
    Task MigrateAsync();
}
