using Localization.Resources.AbpUi;
using Polat.CarFactory.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Polat.CarFactory;

[DependsOn(
    typeof(CarFactoryApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class CarFactoryHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(CarFactoryHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<CarFactoryResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
