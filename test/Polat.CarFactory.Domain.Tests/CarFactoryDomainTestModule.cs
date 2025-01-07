using Volo.Abp.Modularity;

namespace Polat.CarFactory;

[DependsOn(
    typeof(CarFactoryDomainModule),
    typeof(CarFactoryTestBaseModule)
)]
public class CarFactoryDomainTestModule : AbpModule
{

}
