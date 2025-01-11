using Volo.Abp.Modularity;

namespace Syk.Tour;

[DependsOn(
    typeof(TourDomainModule),
    typeof(TourTestBaseModule)
)]
public class TourDomainTestModule : AbpModule
{

}
