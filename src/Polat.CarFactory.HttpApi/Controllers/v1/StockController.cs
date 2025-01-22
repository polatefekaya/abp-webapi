using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Stock;

namespace Polat.CarFactory.Controllers.v1;

public class StockController : CarFactoryController, IStockAppService
{
    public Task AddStock(AddStockCountDto dto)
    {
        throw new NotImplementedException();
    }

    public Task RemoveStock(RemoveStockCountDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetStock(SetStockCountDto dto)
    {
        throw new NotImplementedException();
    }
}
