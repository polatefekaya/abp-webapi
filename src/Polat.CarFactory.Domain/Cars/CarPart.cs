using System;
using Polat.CarFactory.Entities;
using Polat.CarFactory.Enums;
using Polat.CarFactory.ValueObjects;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Cars;

public class CarPart : Entity<Guid>
{
    public Guid CarId {get; private set;}
    public Guid PartId {get; private set;}
    public AxleEnum Axle {get; private set;}
    public string Position {get; private set;}
    public int Quantity {get; private set;}

    public Part Part {get; private set;} = null!;
    protected CarPart(){}

    internal CarPart(Guid id, Guid carId, Guid partId, AxleEnum axle, string position, int quantity) : base(id){
        CarId = carId;
        PartId = partId;

        SetAxle(axle);
        SetQuantity(quantity);
        SetPosition(position);
    }

    public CarPart SetAxle(AxleEnum axle){
        Axle = axle;
        return this;
    }

    public CarPart SetQuantity(int quantity){
        Quantity = Check.Positive(quantity, nameof(Quantity));
        return this;
    }

    public CarPart SetPosition(string position){
        Position = Check.NotNullOrWhiteSpace(position, nameof(Position));
        return this;
    }
    public Money GetTotalPrice(){
        return Part.Price * Quantity;
    }
}
