using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Entities;

public class Stock : Entity<Guid>
{
    public Guid ParentId {get; private set;}
    public int StockCount {get; private set;}

    protected Stock(){}

    internal Stock(Guid id, Guid parentId, int stockCount) : base(id) {
        ParentId = parentId;

        StockCount = Check.Positive(stockCount, "stockCount");
    }
    
    public Stock AddStock(int value){
        Check.Positive(value, "Add Count");

        StockCount += value;
        return this;
    }

    public Stock RemoveStock(int value){
        Check.Positive(value, "Remove Count");

        if(value > StockCount){
            throw new BusinessException(message: "Can not remove values greater than StockCount from StockCount");
        }

        StockCount -= value;
        return this;
    }

    public Stock SetStock(int value){
        if(value < 0) throw new BusinessException(message: "Can not set values less than zero");
        
        StockCount = value;
        return this;
    }
}
