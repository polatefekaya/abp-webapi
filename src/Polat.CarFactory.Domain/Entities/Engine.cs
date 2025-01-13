using System;
using Polat.CarFactory.Consts;
using Polat.CarFactory.Enums;
using Polat.CarFactory.ValueObjects;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Entities;

public class Engine : Entity<Guid>
{
    public EngineEnum EngineType {get; private set;}
    public int Volume {get; private set;}
    public int Cylinder {get; private set;}
    public int HorsePower {get; private set;}
    public int Kw {get; private set;}
    public int Torque {get; private set;}
    public int Weight {get; private set;}
    public Money Price {get; private set;}

    public Stock Stock {get; private set;} = null!;

    protected Engine(){

    }

    internal Engine(Guid id, EngineEnum engineType, int volume, int cylinder, int horsePower, int kw, int torque, int weight, Money price, int stockCount = 0) : base(id){
        SetEngineType(engineType);
        SetVolume(volume);
        SetCylinder(cylinder);
        SetHorsePower(horsePower);
        SetKw(kw);
        SetTorque(torque);
        SetWeight(weight);
        SetPrice(price);
        
        Stock.SetStock(stockCount);
    }
    public Engine SetEngineType(EngineEnum engineType){
        EngineType = engineType;
        return this;
    }

    public Engine SetVolume(int volume){
        Volume = Check.Positive(volume, nameof(Volume));
        return this;
    }

    public Engine SetCylinder(int cylinderCount){
        Cylinder = Check.Range(cylinderCount, nameof(Cylinder), EngineConsts.MinCylinders, EngineConsts.MaxCylinders);
        return this;
    }

    public Engine SetHorsePower(int horsePower){
        HorsePower = Check.Range(horsePower, nameof(HorsePower), EngineConsts.MinHorsePower, EngineConsts.MaxHorsePower);
        return this;
    }

    public Engine SetKw(int kw){
        Kw = Check.Range(kw, nameof(Kw), EngineConsts.MinKw, EngineConsts.MaxKw);
        return this;
    }

    public Engine SetTorque(int torque){
        Torque = Check.Range(torque, nameof(Torque), EngineConsts.MinTorque, EngineConsts.MaxTorque);
        return this;
    }

    public Engine SetWeight(int weight){
        Weight = Check.Positive(weight, nameof(Weight));
        return this;
    }
    
    public Engine SetPrice(Money price){
        Price = price;
        return this;
    }
}
