using Polat.CarFactory.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Polat.CarFactory.Permissions;

public class CarFactoryPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CarFactoryPermissions.GroupName, L("Permission:CarFactory"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CarFactoryResource>(name);
    }
}
