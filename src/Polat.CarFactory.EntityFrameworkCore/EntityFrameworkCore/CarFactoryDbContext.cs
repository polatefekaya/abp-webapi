using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Polat.CarFactory.EntityFrameworkCore;

[ConnectionStringName(CarFactoryDbProperties.ConnectionStringName)]
public class CarFactoryDbContext : AbpDbContext<CarFactoryDbContext>, ICarFactoryDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public CarFactoryDbContext(DbContextOptions<CarFactoryDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureCarFactory();
    }
}
