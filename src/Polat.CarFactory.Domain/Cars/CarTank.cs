using System;
using Polat.CarFactory.Entities;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Cars;

public class CarTank : Entity<Guid>
{
    public Guid CarId {get; private set;}
    public Guid TankId {get; private set;}

    public FuelTank Tank {get; private set;} = null!;
    protected CarTank(){}

    public CarTank(Guid id, Guid carId, Guid tankId) : base(id){
        CarId = carId;
        TankId = tankId;
    }
}
