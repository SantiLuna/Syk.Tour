using Volo.Abp.Settings;

namespace Syk.Tour.Settings;

public class TourSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TourSettings.MySetting1));
    }
}
