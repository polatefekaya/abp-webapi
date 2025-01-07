using Volo.Abp.Modularity;

namespace Polat.CarFactory;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class CarFactoryDomainTestBase<TStartupModule> : CarFactoryTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
