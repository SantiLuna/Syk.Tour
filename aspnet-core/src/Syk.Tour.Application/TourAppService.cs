using System;
using System.Collections.Generic;
using System.Text;
using Syk.Tour.Localization;
using Volo.Abp.Application.Services;

namespace Syk.Tour;

/* Inherit your application services from this class.
 */
public abstract class TourAppService : ApplicationService
{
    protected TourAppService()
    {
        LocalizationResource = typeof(TourResource);
    }
}
