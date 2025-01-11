using Syk.Tour.Samples;
using Xunit;

namespace Syk.Tour.EntityFrameworkCore.Applications;

[Collection(TourTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TourEntityFrameworkCoreTestModule>
{

}
