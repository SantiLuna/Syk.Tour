using Volo.Abp.Modularity;

namespace Syk.Tour;

public abstract class TourApplicationTestBase<TStartupModule> : TourTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
