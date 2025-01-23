using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Part.Get;
using Polat.CarFactory.DTOs.UseCases.Part.Response.Get;

namespace Polat.CarFactory.UseCases.Part.Get;

public class GetPartUseCase : IUseCase<GetPartDto, GetPartResponseDto>
{
    public Task<GetPartResponseDto> ExecuteAsync(GetPartDto dto)
    {
        throw new NotImplementedException();
    }
}
