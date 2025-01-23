using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Part.Get;
using Polat.CarFactory.DTOs.UseCases.Part.Response.Get;

namespace Polat.CarFactory.UseCases.Part.Get;

public class GetPartAxleUseCase : IUseCase<GetPartAxleDto, GetPartAxleResponseDto>
{
    public Task<GetPartAxleResponseDto> ExecuteAsync(GetPartAxleDto dto)
    {
        throw new NotImplementedException();
    }
}
