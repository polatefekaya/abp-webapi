using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Engine;
using Polat.CarFactory.DTOs.UseCases.Generic;

namespace Polat.CarFactory.Controllers.v1;

public class EngineController : CarFactoryController, IEngineAppService
{
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
