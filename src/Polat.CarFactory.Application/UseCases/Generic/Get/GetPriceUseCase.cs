using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;

namespace Polat.CarFactory.UseCases.Generic.Get;

public class GetPriceUseCase : IUseCase<GetPriceDto, GetPriceResponseDto>
{
    public Task<GetPriceResponseDto> ExecuteAsync(GetPriceDto dto)
    {
        throw new NotImplementedException();
    }
}
