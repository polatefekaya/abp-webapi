using Polat.CarFactory.Localization;
using Volo.Abp.Application.Services;

namespace Polat.CarFactory;

public abstract class CarFactoryAppService : ApplicationService
{
    protected CarFactoryAppService()
    {
        LocalizationResource = typeof(CarFactoryResource);
        ObjectMapperContext = typeof(CarFactoryApplicationModule);
    }
}
