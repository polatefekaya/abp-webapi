using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Engine.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Set;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace Polat.CarFactory.AppServices;

public interface IEngineAppService : IWeightAppService, IPriceAppService, IVolumeAppService, IApplicationService, IScopedDependency
{
    public Task SetCylinder(SetEngineCylinderDto dto);
    public Task SetHorsePower(SetEngineHorsePowerDto dto);
    public Task SetKw(SetEngineKwDto dto);
    public Task SetTorque(SetEngineTorqueDto dto);
    public Task SetEngineType(SetEngineTypeDto dto);
    public Task<GetEngineCylinderResponseDto> GetCylinder(GetEngineCylinderDto dto);
    public Task<GetEngineHorsePowerResponseDto> GetHorsePower(GetEngineHorsePowerDto dto);
    public Task<GetEngineKwResponseDto> GetKw(GetEngineKwDto dto);
    public Task<GetEngineTorqueResponseDto> GetTorque(GetEngineTorqueDto dto);
    public Task<GetEngineTypeResponseDto> GetEngineType(GetEngineTypeDto dto);
    public Task<GetEngineResponseDto> GetEngine(GetEngineDto dto);
}
