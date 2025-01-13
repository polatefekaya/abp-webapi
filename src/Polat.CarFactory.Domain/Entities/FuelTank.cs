using System;
using Polat.CarFactory.Enums;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Entities;

public class FuelTank : Entity<Guid>
{
    public int Capacity {get; private set;}
    public FuelTankEnum TankType {get; private set;}

    protected FuelTank(){
    }

    internal FuelTank(Guid id, int capacity, FuelTankEnum type) : base(id){
        SetCapacity(capacity);
        SetTankType(type);
    }

    public FuelTank SetCapacity(int capacity){
        Capacity = Check.Positive(capacity, nameof(Capacity));
        return this;
    }

    public FuelTank SetTankType(FuelTankEnum type){
        TankType = type;
        return this;
    }
}
