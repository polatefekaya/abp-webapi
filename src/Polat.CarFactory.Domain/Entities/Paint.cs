using System;
using Polat.CarFactory.ValueObjects;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Entities;

public class Paint : Entity<Guid>
{
    public Guid PaintId {get; private set;}
    public int StockLitre {get; private set;}
    public string Name {get; private set;}
    public string ColorCode {get; private set;}
    public Money PricePerLitre {get; private set;}

    protected Paint(){

    }

    internal Paint(Guid id) : base(id){
        
    }
}
