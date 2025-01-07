using Polat.CarFactory.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Polat.CarFactory;

public abstract class CarFactoryController : AbpControllerBase
{
    protected CarFactoryController()
    {
        LocalizationResource = typeof(CarFactoryResource);
    }
}
