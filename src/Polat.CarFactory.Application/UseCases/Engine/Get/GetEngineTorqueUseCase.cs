using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Engine.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Response.Get;

namespace Polat.CarFactory.UseCases.Engine.Get;

public class GetEngineTorqueUseCase : IUseCase<GetEngineTorqueDto, GetEngineTorqueResponseDto>
{
    public Task<GetEngineTorqueResponseDto> ExecuteAsync(GetEngineTorqueDto dto)
    {
        throw new NotImplementedException();
    }
}
