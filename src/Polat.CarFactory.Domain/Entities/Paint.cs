using System;
using Polat.CarFactory.ValueObjects;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Entities;

public class Paint : Entity<Guid>
{
    public string Name {get; private set;}
    public string ColorCode {get; private set;}
    public Money PricePerLitre {get; private set;}

    public Stock Stock {get; private set;} = null!;

    protected Paint(){}

    internal Paint(Guid id, string name, string colorCode, Money pricePerLitre, int stockLitre = 0) : base(id){
        SetName(name);
        SetColorCode(colorCode);
        SetPricePerLitre(pricePerLitre);

        Stock.SetStock(stockLitre);
    }


    public Paint SetName(string name){
        Name = Check.NotNullOrWhiteSpace(name, nameof(Name));
        return this;
    }

    public Paint SetColorCode(string colorCode){
        ColorCode = Check.NotNullOrWhiteSpace(colorCode, nameof(ColorCode));
        return this;
    }

    public Paint SetPricePerLitre(Money price){
        PricePerLitre = price;
        return this;
    }

}
