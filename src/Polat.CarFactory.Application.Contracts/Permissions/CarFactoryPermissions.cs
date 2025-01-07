using Volo.Abp.Reflection;

namespace Polat.CarFactory.Permissions;

public class CarFactoryPermissions
{
    public const string GroupName = "CarFactory";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CarFactoryPermissions));
    }
}
