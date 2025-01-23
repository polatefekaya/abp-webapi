using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Get;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Response.Get;

namespace Polat.CarFactory.UseCases.FuelTank.Get;

public class GetFuelTankCapacityUseCase : IUseCase<GetFuelTankCapacityDto, GetFuelTankCapacityResponseDto>
{
    public Task<GetFuelTankCapacityResponseDto> ExecuteAsync(GetFuelTankCapacityDto dto)
    {
        throw new NotImplementedException();
    }
}
