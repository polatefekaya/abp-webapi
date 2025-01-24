using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Part.Get;
using Polat.CarFactory.DTOs.UseCases.Part.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Part.Set;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace Polat.CarFactory.AppServices;

public interface IPartAppService : IGenericAppService, IApplicationService, IScopedDependency
{
    public Task SetAxle(SetPartAxleDto dto);
    public Task SetCategory(SetPartCategoryDto dto);
    public Task<GetPartAxleResponseDto> GetAxle(GetPartAxleDto dto);
    public Task<GetPartCategoryResponseDto> GetCategory(GetPartCategoryDto dto);
    public Task<GetPartResponseDto> GetPart(GetPartDto dto);
}
