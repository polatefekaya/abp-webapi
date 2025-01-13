using System;
using Polat.CarFactory.Enums;
using Polat.CarFactory.ValueObjects;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Entities;

public class Wheel : Entity<Guid>
{
    public Guid WheelId { get; private set; }
    public MaterialEnum Material {get; private set;}
    public int StockCount {get; private set;}
    public int Size {get; private set;}
    public int Weigth {get; private set;}
    public Money Price {get; private set;}
    protected Wheel()
    {
    }

    internal Wheel(Guid id) : base(id)
    {

    }
}
