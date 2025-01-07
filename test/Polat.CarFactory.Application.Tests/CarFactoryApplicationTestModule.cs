using Volo.Abp.Modularity;

namespace Polat.CarFactory;

[DependsOn(
    typeof(CarFactoryApplicationModule),
    typeof(CarFactoryDomainTestModule)
    )]
public class CarFactoryApplicationTestModule : AbpModule
{

}
