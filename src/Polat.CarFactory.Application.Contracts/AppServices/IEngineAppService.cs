using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Engine;

namespace Polat.CarFactory.AppServices;

public interface IEngineAppService : IWeightAppService, IPriceAppService, IVolumeAppService
{
    public Task SetCylinder(SetEngineCylinderDto dto);
    public Task SetHorsePower(SetEngineHorsePowerDto dto);
    public Task SetKw(SetEngineKwDto dto);
    public Task SetTorque(SetEngineTorqueDto dto);
    public Task SetEngineType(SetEngineTypeDto dto);
}
