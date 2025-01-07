using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Polat.CarFactory;

[DependsOn(
    typeof(CarFactoryDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class CarFactoryApplicationContractsModule : AbpModule
{

}
