using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;

namespace Polat.CarFactory.AppServices.Generic;

public interface IVolumeAppService
{
    public Task SetVolume(SetVolumeDto dto);
    public Task<GetVolumeResponseDto> GetVolume(GetVolumeDto dto);
}
