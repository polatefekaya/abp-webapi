using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Polat.CarFactory;

[DependsOn(
    typeof(CarFactoryApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class CarFactoryHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(CarFactoryApplicationContractsModule).Assembly,
            CarFactoryRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CarFactoryHttpApiClientModule>();
        });

    }
}
