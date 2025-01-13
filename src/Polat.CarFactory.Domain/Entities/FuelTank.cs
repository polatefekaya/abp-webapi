using System;
using Polat.CarFactory.Enums;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Entities;

public class FuelTank : Entity<Guid>
{
    public Guid TankId {get; private set;}
    public int Capacity {get; private set;}
    public FuelTankEnum TankType {get; private set;}

    protected FuelTank(){
    }

    internal FuelTank(Guid id) : base(id){

    }
}
