using Volo.Abp.Modularity;

namespace Syk.Tour;

/* Inherit from this class for your domain layer tests. */
public abstract class TourDomainTestBase<TStartupModule> : TourTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
