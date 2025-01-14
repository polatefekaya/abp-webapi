using System;
using Polat.CarFactory.Entities;
using Polat.CarFactory.Enums;
using Polat.CarFactory.ValueObjects;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Cars;

public class CarEngine : Entity<Guid>
{
    public Guid CarId {get; private set;}
    public Guid EngineId {get; private set;}
    public AxleEnum Axle {get; private set;}
    public int Quantity {get; private set;}

    public Engine Engine {get; private set;} = null!;

    protected CarEngine(){}

    internal CarEngine(Guid id, Guid carId, Guid engineId, AxleEnum axle, int quantity) : base(id){
        CarId= carId;
        EngineId = engineId;
        SetAxle(axle);
        SetQuantity(quantity);
    }
    public CarEngine SetQuantity(int quantity){
        Quantity = Check.Positive(quantity, nameof(Quantity));
        return this;
    }
    public CarEngine SetAxle(AxleEnum axle){
        Axle = axle;
        return this;
    }
    public Money GetTotalPrice(){
        return Engine.Price * Quantity;
    }
}
