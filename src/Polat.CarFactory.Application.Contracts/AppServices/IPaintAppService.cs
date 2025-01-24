using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Paint.Get;
using Polat.CarFactory.DTOs.UseCases.Paint.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Paint.Set;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace Polat.CarFactory.AppServices;

public interface IPaintAppService : IPriceAppService, IApplicationService, IScopedDependency
{
    public Task SetColorCode(SetPaintColorCodeDto dto);
    public Task SetName(SetPaintNameDto dto);
    public Task<GetPaintColorCodeResponseDto> GetColorCode(GetPaintColorCodeDto dto);
    public Task<GetPaintNameResponseDto> GetName(GetPaintNameDto dto);
    public Task<GetPaintResponseDto> GetPaint(GetPaintDto dto);
}
