using System;
using Polat.CarFactory.Enums;
using Polat.CarFactory.ValueObjects;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Entities;

public class Part : Entity<Guid>
{
    public Guid PartId {get; private set;}
    public string Name {get; private set;}
    public MaterialEnum Material {get; private set;}
    public int Weigth {get; private set;}
    public int Volume {get; private set;}
    public PartCategoryEnum Category {get; private set;}
    public int StockCount {get; private set;}
    public AxleEnum Axle {get; private set;}
    public Money Price {get; private set;}
    
    protected Part(){}

    internal Part(Guid id) : base(id){
        
    }
}
