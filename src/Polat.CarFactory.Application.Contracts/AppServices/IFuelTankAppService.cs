using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Get;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Response.Get;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Set;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace Polat.CarFactory.AppServices;

public interface IFuelTankAppService : IPriceAppService, IApplicationService, IScopedDependency
{
    public Task SetCapacity(SetFuelTankCapacityDto dto);
    public Task SetTankType(SetFuelTankTypeDto dto);
    public Task<GetFuelTankCapacityResponseDto> GetCapacity(GetFuelTankCapacityDto dto);
    public Task<GetFuelTankTypeResponseDto> GetTankType(GetFuelTankTypeDto dto);
    public Task<GetFuelTankResponseDto> GetTank(GetFuelTankDto dto);
}
