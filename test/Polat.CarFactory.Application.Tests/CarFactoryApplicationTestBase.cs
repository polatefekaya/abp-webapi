using Volo.Abp.Modularity;

namespace Polat.CarFactory;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class CarFactoryApplicationTestBase<TStartupModule> : CarFactoryTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
