using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Stock.Get;
using Polat.CarFactory.DTOs.UseCases.Stock.Response.Get;

namespace Polat.CarFactory.UseCases.Stock.Get;

public class GetStockCountUseCase : IUseCase<GetStockCountDto, GetStockCountResponseDto>
{
    public Task<GetStockCountResponseDto> ExecuteAsync(GetStockCountDto dto)
    {
        throw new NotImplementedException();
    }
}
