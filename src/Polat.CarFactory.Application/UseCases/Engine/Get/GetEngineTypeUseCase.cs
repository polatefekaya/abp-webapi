using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Engine.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Response.Get;

namespace Polat.CarFactory.UseCases.Engine.Get;

public class GetEngineTypeUseCase : IUseCase<GetEngineTypeDto, GetEngineTypeResponseDto>
{
    public Task<GetEngineTypeResponseDto> ExecuteAsync(GetEngineTypeDto dto)
    {
        throw new NotImplementedException();
    }
}
