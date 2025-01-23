using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.DTOs.UseCases.Wheel.Get;
using Polat.CarFactory.DTOs.UseCases.Wheel.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Wheel.Set;

namespace Polat.CarFactory.Controllers.v1;

public class WheelController : CarFactoryController, IWheelAppService
{
    public Task<GetMaterialResponseDto> GetMaterial(GetMaterialDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetPriceResponseDto> GetPrice(GetPriceDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetWheelSizeResponseDto> GetSize(GetWheelSizeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetWeightResponseDto> GetWeight(GetWeightDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetWheelResponseDto> GetWheel(GetWheelDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetMaterial(SetMaterialDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetPrice(SetPriceDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetSize(SetWheelSizeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetWeight(SetWeightDto dto)
    {
        throw new NotImplementedException();
    }
}
