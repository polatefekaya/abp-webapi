using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;

namespace Polat.CarFactory.AppServices.Generic;

public interface IPriceAppService
{
    public Task SetPrice(SetPriceDto dto);
    public Task<GetPriceResponseDto> GetPrice(GetPriceDto dto);
}
