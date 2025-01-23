using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Engine.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Response.Get;

namespace Polat.CarFactory.UseCases.Engine.Get;

public class GetEngineKwUseCase : IUseCase<GetEngineKwDto, GetEngineKwResponseDto>
{
    public Task<GetEngineKwResponseDto> ExecuteAsync(GetEngineKwDto dto)
    {
        throw new NotImplementedException();
    }
}
