using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Syk.Tour.Data;

/* This is used if database provider does't define
 * ITourDbSchemaMigrator implementation.
 */
public class NullTourDbSchemaMigrator : ITourDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
