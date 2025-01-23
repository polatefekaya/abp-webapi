using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Body.Get;
using Polat.CarFactory.DTOs.UseCases.Body.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Body.Set;
using Volo.Abp.Application.Services;

namespace Polat.CarFactory.AppServices;

public interface IBodyAppService : IGenericAppService, IApplicationService
{
    public Task SetCd(SetBodyCdDto dto);
    public Task SetBodyType(SetBodyTypeDto dto);
    public Task SetDoorCount(SetBodyDoorCountDto dto);
    public Task<GetBodyCdResponseDto> GetCd(GetBodyCdDto dto);
    public Task<GetBodyTypeResponseDto> GetBodyType(GetBodyTypeDto dto);
    public Task<GetBodyDoorCountResponseDto> GetDoorCount(GetBodyDoorCountDto dto);
    public Task<GetBodyResponseDto> GetBody(GetBodyDto dto);
}
