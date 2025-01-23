using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;

namespace Polat.CarFactory.UseCases.Generic.Get;

public class GetVolumeUseCase : IUseCase<GetVolumeDto, GetVolumeResponseDto>
{
    public Task<GetVolumeResponseDto> ExecuteAsync(GetVolumeDto dto)
    {
        throw new NotImplementedException();
    }
}
