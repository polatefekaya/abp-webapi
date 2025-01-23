using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Stock.Get;
using Polat.CarFactory.DTOs.UseCases.Stock.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Stock.Set;
using Volo.Abp.Application.Services;

namespace Polat.CarFactory.AppServices;

public interface IStockAppService : IApplicationService
{
    public Task AddCount(AddStockCountDto dto);
    public Task RemoveCount(RemoveStockCountDto dto);
    public Task SetCount(SetStockCountDto dto);

    public Task<GetStockCountResponseDto> GetCount(GetStockCountDto dto);
    public Task<GetStockResponseDto> GetStock(GetStockDto dto);
}
