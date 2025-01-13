using System;
using Polat.CarFactory.Enums;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Cars;

public class CarWheel : Entity<Guid>
{
    public Guid CarId {get; private set;}
    public Guid WheelId {get; private set;}
    public AxleEnum Axle {get; private set;}
    public int Quantity {get; private set;}

    protected CarWheel(){}

    internal CarWheel(Guid id) : base(id){
        
    }
}
