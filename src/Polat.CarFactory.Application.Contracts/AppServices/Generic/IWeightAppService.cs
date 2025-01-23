using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;

namespace Polat.CarFactory.AppServices.Generic;

public interface IWeightAppService
{
    public Task SetWeight(SetWeightDto dto);
    public Task<GetWeightResponseDto> GetWeight(GetWeightDto dto);
}
