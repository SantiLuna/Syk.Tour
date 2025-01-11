using Microsoft.Extensions.Localization;
using Syk.Tour.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Syk.Tour;

[Dependency(ReplaceServices = true)]
public class TourBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TourResource> _localizer;

    public TourBrandingProvider(IStringLocalizer<TourResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
