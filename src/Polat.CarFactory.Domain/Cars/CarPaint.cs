using System;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Cars;

public class CarPaint : Entity<Guid>
{
    public Guid CarId {get; private set;}
    public Guid PaintId {get; private set;}
    public int Litres {get; private set;}

    protected CarPaint(){}

    internal CarPaint(Guid id) : base(id){
        
    }
}
