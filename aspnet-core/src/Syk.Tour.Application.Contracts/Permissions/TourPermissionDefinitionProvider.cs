using Syk.Tour.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Syk.Tour.Permissions;

public class TourPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TourPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TourPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TourResource>(name);
    }
}
