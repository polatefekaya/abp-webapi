using System;
using Polat.CarFactory.Consts;
using Polat.CarFactory.Enums;
using Polat.CarFactory.ValueObjects;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Entities;

public class Wheel : Entity<Guid>
{
    public MaterialEnum Material {get; private set;}
    public int StockCount {get; private set;}
    public int Size {get; private set;}
    public int Weight {get; private set;}
    public Money Price {get; private set;}

    public Stock Stock {get; private set;} = null!;

    protected Wheel(){}

    internal Wheel(Guid id, int size, int weight, MaterialEnum material, Money price, int stockCount = 0) : base(id)
    {
        SetSize(size);
        SetWeight(weight);
        SetMaterial(material);

        Stock.SetStock(stockCount);

        Price = price;
    }

    public Wheel SetMaterial(MaterialEnum material){
        Material = material;
        return this;
    }

    public Wheel SetPrice(Money money){
        Price = money;
        return this;
    }

    public Wheel SetWeight(int value){
        Weight = Check.Positive(value, "Weight");
        return this;
    }

    public Wheel SetSize(int value){
        Size = Check.Range(value, "Size", WheelConsts.MinSize, WheelConsts.MaxSize);
        return this;
    }
}
