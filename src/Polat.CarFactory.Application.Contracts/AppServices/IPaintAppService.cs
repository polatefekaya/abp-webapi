using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Paint;

namespace Polat.CarFactory.AppServices;

public interface IPaintAppService : IPriceAppService
{
    public Task SetColorCode(SetPaintColorCodeDto dto);
    public Task SetName(SetPaintNameDto dto);
}
