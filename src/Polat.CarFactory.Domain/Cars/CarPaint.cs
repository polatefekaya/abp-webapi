using System;
using Polat.CarFactory.Entities;
using Polat.CarFactory.ValueObjects;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Cars;

public class CarPaint : Entity<Guid>
{
    public Guid CarId {get; private set;}
    public Guid PaintId {get; private set;}
    public int Litres {get; private set;}

    public Paint Paint {get; private set;} = null!;

    protected CarPaint(){}

    internal CarPaint(Guid id, Guid carId, Guid paintId, int litres) : base(id){
        CarId = carId;
        PaintId = paintId;
        SetLitres(litres);
    }

    public CarPaint SetLitres(int litres){
        Litres = Check.Positive(litres, nameof(Litres));
        return this;
    }
    public Money GetTotalPrice(){
        return Paint.PricePerLitre * Litres;
    }
}
