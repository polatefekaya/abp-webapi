using System;
using Polat.CarFactory.Consts;
using Polat.CarFactory.Enums;
using Polat.CarFactory.ValueObjects;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Entities;

public class Body : Entity<Guid>
{
    public MaterialEnum Material {get; private set;}
    public int Weight {get; private set;}
    public int Volume {get; private set;}
    public decimal Cd {get; private set;}
    public BodyEnum BodyType {get; private set;}
    public int Doors {get; private set;}
    public Money Price {get; private set;}

    public Stock Stock {get; private set;} = null!;

    protected Body(){
    }

    internal Body(Guid id, MaterialEnum material, int weight, int volume, decimal cd, BodyEnum bodyType, int doors, Money price, int stockCount = 0) : base(id){
        SetMaterial(material);
        SetWeight(weight);
        SetVolume(volume);
        SetCd(cd);
        SetBodyType(bodyType);
        SetDoorCount(doors);
        SetPrice(price);

        Stock.SetStock(stockCount);
    }

    public Body SetMaterial(MaterialEnum material){
        Material = material;
        return this;
    }

    public Body SetWeight(int weight){
        Weight = Check.Positive(weight, nameof(Weight));
        return this;
    }

    public Body SetVolume(int volume){
        Volume = Check.Positive(volume, nameof(Volume));
        return this;
    }

    public Body SetCd(decimal value){
        Cd = Check.Positive(value, nameof(Cd));
        return this;
    }

    public Body SetBodyType(BodyEnum bodyType){
        BodyType = bodyType;
        return this;
    }

    public Body SetDoorCount(int count){
        Doors = Check.Range(count, nameof(Doors), BodyConsts.MinDoorCount, BodyConsts.MaxDoorCount);
        return this;
    }

    public Body SetPrice(Money price){
        Price = price;
        return this;
    }
}
