using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Engine.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Set;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;

namespace Polat.CarFactory.Controllers.v1;

public class EngineController : CarFactoryController, IEngineAppService
{
    public Task<GetEngineCylinderResponseDto> GetCylinder(GetEngineCylinderDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetEngineResponseDto> GetEngine(GetEngineDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetEngineTypeResponseDto> GetEngineType(GetEngineTypeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetEngineHorsePowerResponseDto> GetHorsePower(GetEngineHorsePowerDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetEngineKwResponseDto> GetKw(GetEngineKwDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetPriceResponseDto> GetPrice(GetPriceDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetEngineTorqueResponseDto> GetTorque(GetEngineTorqueDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetVolumeResponseDto> GetVolume(GetVolumeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetWeightResponseDto> GetWeight(GetWeightDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetCylinder(SetEngineCylinderDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetEngineType(SetEngineTypeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetHorsePower(SetEngineHorsePowerDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetKw(SetEngineKwDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetPrice(SetPriceDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetTorque(SetEngineTorqueDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetVolume(SetVolumeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetWeight(SetWeightDto dto)
    {
        throw new NotImplementedException();
    }
}
