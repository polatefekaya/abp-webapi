using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Get;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Response.Get;

namespace Polat.CarFactory.UseCases.FuelTank.Get;

public class GetFuelTankUseCase : IUseCase<GetFuelTankDto, GetFuelTankResponseDto>
{
    public Task<GetFuelTankResponseDto> ExecuteAsync(GetFuelTankDto dto)
    {
        throw new NotImplementedException();
    }
}
