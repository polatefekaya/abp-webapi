using System;
using Polat.CarFactory.Enums;
using Polat.CarFactory.ValueObjects;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Entities;

public class Engine : Entity<Guid>
{
    public Guid EngineId {get; private set;}
    public EngineEnum EngineType {get; private set;}
    public int Volume {get; private set;}
    public int Cylinder {get; private set;}
    public int HorsePower {get; private set;}
    public int Kw {get; private set;}
    public int Torque {get; private set;}
    public int Weigth {get; private set;}
    public int StockCount {get; private set;}
    public Money Price {get; private set;}

    protected Engine(){

    }

    internal Engine(Guid id) : base(id){

    }
}
