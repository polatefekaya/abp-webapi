using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Polat.CarFactory;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class CarFactoryInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CarFactoryInstallerModule>();
        });
    }
}
