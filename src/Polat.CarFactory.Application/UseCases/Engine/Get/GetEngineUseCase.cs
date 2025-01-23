using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Engine.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Response.Get;

namespace Polat.CarFactory.UseCases.Engine.Get;

public class GetEngineUseCase : IUseCase<GetEngineDto, GetEngineResponseDto>
{
    public Task<GetEngineResponseDto> ExecuteAsync(GetEngineDto dto)
    {
        throw new NotImplementedException();
    }
}
