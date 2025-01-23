using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Engine.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Response.Get;

namespace Polat.CarFactory.UseCases.Engine.Get;

public class GetEngineHorsePowerUseCase : IUseCase<GetEngineHorsePowerDto, GetEngineHorsePowerResponseDto>
{
    public Task<GetEngineHorsePowerResponseDto> ExecuteAsync(GetEngineHorsePowerDto dto)
    {
        throw new NotImplementedException();
    }
}
