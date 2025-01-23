using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Body.Get;
using Polat.CarFactory.DTOs.UseCases.Body.Response.Get;

namespace Polat.CarFactory.UseCases.Body.Get;

public class GetBodyUseCase : IUseCase<GetBodyDto, GetBodyResponseDto>
{
    public Task<GetBodyResponseDto> ExecuteAsync(GetBodyDto dto)
    {
        throw new NotImplementedException();
    }
}
