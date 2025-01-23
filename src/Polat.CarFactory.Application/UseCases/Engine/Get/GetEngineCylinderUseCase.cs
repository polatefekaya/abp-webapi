using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Engine.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Response.Get;

namespace Polat.CarFactory.UseCases.Engine.Get;

public class GetEngineCylinderUseCase : IUseCase<GetEngineCylinderDto, GetEngineCylinderResponseDto>
{
    public Task<GetEngineCylinderResponseDto> ExecuteAsync(GetEngineCylinderDto dto)
    {
        throw new NotImplementedException();
    }
}
