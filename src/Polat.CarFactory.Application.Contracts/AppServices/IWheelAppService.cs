using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Wheel.Get;
using Polat.CarFactory.DTOs.UseCases.Wheel.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Wheel.Set;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace Polat.CarFactory.AppServices;

public interface IWheelAppService : IMaterialAppService, IPriceAppService, IWeightAppService, IApplicationService, IScopedDependency
{
    public Task SetSize(SetWheelSizeDto dto);
    public Task<GetWheelSizeResponseDto> GetSize(GetWheelSizeDto dto);
    public Task<GetWheelResponseDto> GetWheel(GetWheelDto dto);
}
