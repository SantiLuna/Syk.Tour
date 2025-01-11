using Syk.Tour.Samples;
using Xunit;

namespace Syk.Tour.EntityFrameworkCore.Domains;

[Collection(TourTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TourEntityFrameworkCoreTestModule>
{

}
