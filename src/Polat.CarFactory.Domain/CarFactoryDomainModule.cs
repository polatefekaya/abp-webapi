using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Polat.CarFactory;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(CarFactoryDomainSharedModule)
)]
public class CarFactoryDomainModule : AbpModule
{

}
