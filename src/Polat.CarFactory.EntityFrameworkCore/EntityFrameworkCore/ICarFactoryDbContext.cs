using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Polat.CarFactory.EntityFrameworkCore;

[ConnectionStringName(CarFactoryDbProperties.ConnectionStringName)]
public interface ICarFactoryDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
