using System;
using Polat.CarFactory.Entities;
using Polat.CarFactory.Enums;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Cars;

public class CarWheel : Entity<Guid>
{
    public Guid CarId {get; private set;}
    public Guid WheelId {get; private set;}
    public AxleEnum Axle {get; private set;}
    public int Quantity {get; private set;}
    public Wheel Wheel {get; private set;} = null!;

    protected CarWheel(){}

    internal CarWheel(Guid id, Guid carId, Guid wheelId, AxleEnum axle, int quantity) : base(id){
        CarId = carId;
        WheelId = wheelId;
        SetAxle(axle);
        SetQuantity(quantity);
    }

    public CarWheel SetQuantity(int value){
        Quantity = Check.Positive(value, nameof(Quantity));
        return this;
    }

    public CarWheel SetAxle(AxleEnum axle){
        Axle = axle;
        return this;
    }
}
