using System;
using System.Collections.Generic;
using System.Linq;
using Polat.CarFactory.Consts;
using Polat.CarFactory.Entities;
using Polat.CarFactory.Enums;
using Polat.CarFactory.ValueObjects;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Polat.CarFactory.Cars;

public class Car : FullAuditedAggregateRoot<Guid>
{
    public CarBody Body {get; private set;}
    public CarTank Tank {get; private set;}
    public ICollection<CarPart> Parts {get; private set;}
    public ICollection<CarWheel> Wheels {get; private set;}
    public ICollection<CarPaint> Paints {get; private set;}
    public ICollection<CarEngine> Engines {get; private set;}
    public Money Price {get; private set;}
    public bool Ready {get; private set;} = false;
    public CarStateEnum State {get; private set;} = CarStateEnum.Draft;

    protected Car() {}

    internal Car(Guid id, CarBody body, CarTank tank, Money price, ICollection<CarPart>? parts = null, ICollection<CarWheel>? wheels = null, ICollection<CarPaint>? paints = null, ICollection<CarEngine>? engines = null) : base(id){
        SetBody(body);
        SetTank(tank);
        SetPrice(price);

        Parts = parts ?? [];
        Wheels = wheels ?? [];
        Paints = paints ?? [];
        Engines = engines ?? [];
    }
    public Car SetBody(CarBody body){
        Body = body;
        return this;
    }
    public Car SetTank(CarTank tank){
        Tank = tank;
        return this;
    }
    public Car Add<T>(T value) where T : Entity<Guid>{
        ICollection<T>? collection = GetCollectionForType<T>();
        if(collection is null){
            throw new InvalidOperationException("NULL");
        }

        if(Exists<T>(collection, value)){
            throw new BusinessException(message: $"Can not add {nameof(T)}, collection ({nameof(ICollection<T>)}) contains same element!");
        }
        collection.Add(value);
        
        return this;
    }

    public Car Remove<T>(T value) where T : Entity<Guid>{
        ICollection<T> collection = GetCollection<T>();

        if(!Exists<T>(collection, value)){
            throw new BusinessException(message: $"Can not delete {nameof(T)}, collection ({nameof(ICollection<T>)}) already does not contains the element!");
        }

        collection.Remove(value);

        return this;
    }

    public Car Remove<T>(Guid id) where T : Entity<Guid>{
        ICollection<T> collection = GetCollection<T>();

        T? value = GetById<T>(collection, id);

        if(value is null){
            throw new BusinessException(message: $"Can not delete {nameof(T)}, collection ({nameof(ICollection<T>)}) already does not contains the element!");
        }

        collection.Remove(value);

        return this;
    }

    public Car Update<T>(T value) where T : Entity<Guid>{
        ICollection<T> collection = GetCollection<T>();

        T? oldVal = GetById<T>(collection, value.Id);

        if(oldVal is null){
            throw new BusinessException(message: $"Can not update {nameof(T)}, collection ({nameof(ICollection<T>)}) does not contains same element!");
        }
        
        collection.Remove(oldVal);
        collection.Add(value);
        
        return this;
    }
    public Car SetPrice(Money price){
        Price = price;
        return this;
    }
    public Money TotalPrice(){
        return TotalEnginesPrice() + TotalPartsPrice() + TotalWheelsPrice() + TotalPaintsPrice();
    }
    public Money TotalPartsPrice(){
        decimal sum = Parts.Sum(p=> p.GetTotalPrice().Amount);
        return new Money(sum, Parts.First().Part.Price.Currency);
    }
    public Money TotalWheelsPrice(){
        decimal sum = Wheels.Sum(p=> p.GetTotalPrice().Amount);
        return new Money(sum, Wheels.First().Wheel.Price.Currency);
    }
    public Money TotalPaintsPrice(){
        decimal sum = Paints.Sum(p=> p.GetTotalPrice().Amount);
        return new Money(sum, Paints.First().Paint.PricePerLitre.Currency);
    }
    public Money TotalEnginesPrice(){
        decimal sum = Engines.Sum(p=> p.GetTotalPrice().Amount);
        return new Money(sum, Engines.First().Engine.Price.Currency);
    }
    
    public bool IsEligible(){
        bool eligible = Engines.Count >= CarConsts.MinEngine &&
                        Paints.Count >= CarConsts.MinPaints &&
                        Wheels.Count >= CarConsts.MinWheels;
        return eligible;
    }
    public bool IsFinalized(){
        return State == CarStateEnum.Finalized;
    }

    public Car MarkEligible(){
        if (IsEligible() && !IsFinalized())
        {
            State = CarStateEnum.Eligible;
        }

        return this;
    }

    public void CheckEligible(string? customMessage = null){
        if(!IsEligible()){
            throw new BusinessException($"{customMessage}\n Car is not eligible. It must have at least {CarConsts.MinEngine} engine, {CarConsts.MinPaints} paint, and {CarConsts.MinWheels} wheels.");
        }
    }

    public Car FinalizeCar(){
        CheckEligible("Car must be eligible before it can be finalized.");

        State = CarStateEnum.Finalized;
        Ready = true;

        return this;
    }

    private ICollection<T> GetCollection<T>() where T : Entity<Guid>{
        ICollection<T>? collection = GetCollectionForType<T>();
        if(collection is null){
            throw new InvalidOperationException("NULL");
        }
        return collection;
    }
    private ICollection<T>? GetCollectionForType<T>() where T : class
    {
        return typeof(T) switch
        {
            _ when typeof(T) == typeof(CarPart) => Parts as ICollection<T>,
            _ when typeof(T) == typeof(CarWheel) => Wheels as ICollection<T>,
            _ when typeof(T) == typeof(CarPaint) => Paints as ICollection<T>,
            _ when typeof(T) == typeof(CarEngine) => Engines as ICollection<T>,
            _ => throw new InvalidOperationException($"No collection is defined for type {typeof(T).Name}.")
        };
    }
    private bool Exists<T>(ICollection<T> collection, T value) where T: Entity<Guid>{
        return collection.Where(i => i.Id == value.Id).Any();
    }
    private bool Exists<T>(ICollection<T> collection, Guid id) where T: Entity<Guid>{
        return collection.Where(i => i.Id == id).Any();
    }
    private T? GetById<T>(ICollection<T> collection, Guid id) where T: Entity<Guid>{
        return collection.FirstOrDefault(i => i.Id == id);
    }
}
