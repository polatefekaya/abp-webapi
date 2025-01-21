using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Polat.CarFactory;

[Route("api/v1/[controller]/[action]")]
public abstract class CarFactoryController : AbpControllerBase
{
    protected CarFactoryController()
    {
        LocalizationResource = typeof(CarFactoryResource);
    }
}
