using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Generic;
using Polat.CarFactory.DTOs.UseCases.Paint;

namespace Polat.CarFactory.Controllers.v1;

public class PaintController : CarFactoryController, IPaintAppService
{
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
