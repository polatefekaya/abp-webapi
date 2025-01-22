using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Generic;
using Polat.CarFactory.ValueObjects;

namespace Polat.CarFactory.AppServices.Generic;

public interface IPriceAppService
{
    public Task SetPrice(SetPriceDto dto);
}
