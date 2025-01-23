using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Stock.Get;
using Polat.CarFactory.DTOs.UseCases.Stock.Response.Get;

namespace Polat.CarFactory.UseCases.Stock.Get;

public class GetStockUseCase : IUseCase<GetStockDto, GetStockResponseDto>
{
    public Task<GetStockResponseDto> ExecuteAsync(GetStockDto dto)
    {
        throw new NotImplementedException();
    }
}
