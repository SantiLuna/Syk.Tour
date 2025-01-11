using Syk.Tour.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Syk.Tour.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TourController : AbpControllerBase
{
    protected TourController()
    {
        LocalizationResource = typeof(TourResource);
    }
}
