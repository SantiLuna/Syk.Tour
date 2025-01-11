using Syk.Tour.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Syk.Tour.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TourEntityFrameworkCoreModule),
    typeof(TourApplicationContractsModule)
    )]
public class TourDbMigratorModule : AbpModule
{
}
