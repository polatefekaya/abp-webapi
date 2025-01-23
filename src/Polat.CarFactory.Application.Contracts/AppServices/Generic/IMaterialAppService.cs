using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.Enums;

namespace Polat.CarFactory.AppServices.Generic;

public interface IMaterialAppService
{
    public Task SetMaterial(SetMaterialDto dto);
    public Task<GetMaterialResponseDto> GetMaterial(GetMaterialDto dto);
}
