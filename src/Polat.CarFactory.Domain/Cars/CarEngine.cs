using System;
using Polat.CarFactory.Enums;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Cars;

public class CarEngine : Entity<Guid>
{
    public Guid CarId {get; private set;}
    public Guid EngineId {get; private set;}
    public AxleEnum Axle {get; private set;}
    public int Quantity {get; private set;}

    protected CarEngine(){}

    internal CarEngine(Guid id) : base(id){
        
    }
}
