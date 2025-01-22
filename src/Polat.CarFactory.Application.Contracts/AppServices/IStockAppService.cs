using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Stock;

namespace Polat.CarFactory.AppServices;

public interface IStockAppService
{
    public Task AddStock(AddStockCountDto dto);
    public Task RemoveStock(RemoveStockCountDto dto);
    public Task SetStock(SetStockCountDto dto);
}
