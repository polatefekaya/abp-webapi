using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Wheel.Get;
using Polat.CarFactory.DTOs.UseCases.Wheel.Response.Get;

namespace Polat.CarFactory.UseCases.Wheel.Get;

public class GetWheelUseCase : IUseCase<GetWheelDto, GetWheelResponseDto>
{
    public Task<GetWheelResponseDto> ExecuteAsync(GetWheelDto dto)
    {
        throw new NotImplementedException();
    }
}
