using System;
using Polat.CarFactory.Enums;
using Polat.CarFactory.ValueObjects;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Entities;

public class Part : Entity<Guid>
{
    public string Name {get; private set;}
    public MaterialEnum Material {get; private set;}
    public int Weight {get; private set;}
    public int Volume {get; private set;}
    public PartCategoryEnum Category {get; private set;}
    public AxleEnum Axle {get; private set;}
    public Money Price {get; private set;}
    
    public Stock Stock {get; private set;} = null!;

    protected Part(){}

    internal Part(Guid id, MaterialEnum material, int weight, int volume, PartCategoryEnum category, AxleEnum axle, Money price, int stockCount = 0) : base(id){
        SetMaterial(material);
        SetWeight(weight);
        SetVolume(volume);
        SetCategory(category);
        SetAxle(axle);
        SetPrice(price);

        Stock.SetStock(stockCount);
    }

    public Part SetMaterial(MaterialEnum material){
        Material = material;
        return this;
    }

    public Part SetWeight(int value){
        Weight = Check.Positive(value, nameof(Weight));
        return this;
    }

    public Part SetVolume(int value){
        Volume = Check.Positive(value, nameof(Volume));
        return this;
    }

    public Part SetCategory(PartCategoryEnum category){
        Category = category;
        return this;
    }

    public Part SetAxle(AxleEnum axle){
        Axle = axle;
        return this;
    }
    public Part SetPrice(Money money){
        Price = money;
        return this;
    }
}
