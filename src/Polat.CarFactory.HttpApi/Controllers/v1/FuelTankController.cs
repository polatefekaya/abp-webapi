using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Get;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Response.Get;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Set;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;

namespace Polat.CarFactory.Controllers.v1;

public class FuelTankController : CarFactoryController, IFuelTankAppService
{
    public Task<GetFuelTankCapacityResponseDto> GetCapacity(GetFuelTankCapacityDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetPriceResponseDto> GetPrice(GetPriceDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetFuelTankResponseDto> GetTank(GetFuelTankDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetFuelTankTypeResponseDto> GetTankType(GetFuelTankTypeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetCapacity(SetFuelTankCapacityDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetPrice(SetPriceDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetTankType(SetFuelTankTypeDto dto)
    {
        throw new NotImplementedException();
    }
}
