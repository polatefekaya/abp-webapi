using System;
using System.Collections.Generic;
using Polat.CarFactory.Entities;
using Polat.CarFactory.ValueObjects;
using Volo.Abp.Domain.Entities.Auditing;

namespace Polat.CarFactory.Cars;

public class Car : FullAuditedAggregateRoot<Guid>
{
    public Body CarBody {get; private set;}
    public CarTank Tank {get; private set;}
    public ICollection<CarPart> Parts {get; private set;}
    public ICollection<CarWheel> Wheels {get; private set;}
    public ICollection<CarPaint> Paints {get; private set;}
    public ICollection<CarEngine> Engines {get; private set;}
    public Money Price {get; private set;}
    protected Car() {}

    internal Car(Guid id) : base(id){
    }


}
