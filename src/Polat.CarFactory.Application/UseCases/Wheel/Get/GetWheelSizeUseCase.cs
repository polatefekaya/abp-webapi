using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Wheel.Get;
using Polat.CarFactory.DTOs.UseCases.Wheel.Response.Get;

namespace Polat.CarFactory.UseCases.Wheel.Get;

public class GetWheelSizeUseCase : IUseCase<GetWheelSizeDto, GetWheelSizeResponseDto>
{
    public Task<GetWheelSizeResponseDto> ExecuteAsync(GetWheelSizeDto dto)
    {
        throw new NotImplementedException();
    }
}
