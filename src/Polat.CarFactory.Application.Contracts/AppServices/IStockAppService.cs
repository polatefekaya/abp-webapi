using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Stock.Get;
using Polat.CarFactory.DTOs.UseCases.Stock.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Stock.Set;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace Polat.CarFactory.AppServices;

public interface IStockAppService : IApplicationService, IScopedDependency
{
    public Task AddCount(AddStockCountDto dto);
    public Task RemoveCount(RemoveStockCountDto dto);
    public Task SetCount(SetStockCountDto dto);

    public Task<GetStockCountResponseDto> GetCount(GetStockCountDto dto);
    public Task<GetStockResponseDto> GetStock(GetStockDto dto);
}
