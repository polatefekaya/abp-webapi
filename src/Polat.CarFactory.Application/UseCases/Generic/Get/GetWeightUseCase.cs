using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;

namespace Polat.CarFactory.UseCases.Generic.Get;

public class GetWeightUseCase : IUseCase<GetWeightDto, GetWeightResponseDto>
{
    public Task<GetWeightResponseDto> ExecuteAsync(GetWeightDto dto)
    {
        throw new NotImplementedException();
    }
}
