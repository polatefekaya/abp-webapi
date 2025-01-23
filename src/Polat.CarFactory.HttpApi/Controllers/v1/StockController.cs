using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Stock.Get;
using Polat.CarFactory.DTOs.UseCases.Stock.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Stock.Set;

namespace Polat.CarFactory.Controllers.v1;

public class StockController : CarFactoryController, IStockAppService
{
    public Task AddCount(AddStockCountDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetStockCountResponseDto> GetCount(GetStockCountDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetStockResponseDto> GetStock(GetStockDto dto)
    {
        throw new NotImplementedException();
    }

    public Task RemoveCount(RemoveStockCountDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetCount(SetStockCountDto dto)
    {
        throw new NotImplementedException();
    }
}
