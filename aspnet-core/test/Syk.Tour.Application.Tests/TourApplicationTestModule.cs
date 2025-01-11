using Volo.Abp.Modularity;

namespace Syk.Tour;

[DependsOn(
    typeof(TourApplicationModule),
    typeof(TourDomainTestModule)
)]
public class TourApplicationTestModule : AbpModule
{

}
