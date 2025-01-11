using Xunit;

namespace Syk.Tour.EntityFrameworkCore;

[CollectionDefinition(TourTestConsts.CollectionDefinitionName)]
public class TourEntityFrameworkCoreCollection : ICollectionFixture<TourEntityFrameworkCoreFixture>
{

}
