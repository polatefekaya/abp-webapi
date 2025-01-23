using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Get;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Response.Get;

namespace Polat.CarFactory.UseCases.FuelTank.Get;

public class GetFuelTankTypeUseCase : IUseCase<GetFuelTankTypeDto, GetFuelTankTypeResponseDto>
{
    public Task<GetFuelTankTypeResponseDto> ExecuteAsync(GetFuelTankTypeDto dto)
    {
        throw new NotImplementedException();
    }
}
