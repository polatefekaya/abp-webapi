using System;
using Polat.CarFactory.Enums;
using Polat.CarFactory.ValueObjects;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Entities;

public class Body : Entity<Guid>
{
    public MaterialEnum Material {get; private set;}
    public int Weigth {get; private set;}
    public int Volume {get; private set;}
    public decimal Cd {get; private set;}
    public BodyEnum Type {get; private set;}
    public int Doors {get; private set;}
    public Money Price {get; private set;}

    protected Body(){
    }

    internal Body(Guid id) : base(id){
        
    }
}
