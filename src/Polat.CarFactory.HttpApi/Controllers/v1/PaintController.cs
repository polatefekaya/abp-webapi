using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.DTOs.UseCases.Paint.Get;
using Polat.CarFactory.DTOs.UseCases.Paint.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Paint.Set;

namespace Polat.CarFactory.Controllers.v1;

public class PaintController : CarFactoryController, IPaintAppService
{
    public Task<GetPaintColorCodeResponseDto> GetColorCode(GetPaintColorCodeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetPaintNameResponseDto> GetName(GetPaintNameDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetPaintResponseDto> GetPaint(GetPaintDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetPriceResponseDto> GetPrice(GetPriceDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetColorCode(SetPaintColorCodeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetName(SetPaintNameDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetPrice(SetPriceDto dto)
    {
        throw new NotImplementedException();
    }
}
