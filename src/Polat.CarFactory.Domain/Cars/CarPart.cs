using System;
using Polat.CarFactory.Enums;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Cars;

public class CarPart : Entity<Guid>
{
    public Guid CarId {get; private set;}
    public Guid PartId {get; private set;}
    public AxleEnum Axle {get; private set;}
    public string Position {get; private set;}
    public int Quantity {get; private set;}

    protected CarPart(){}

    internal CarPart(Guid id ) : base(id){

    }
}
