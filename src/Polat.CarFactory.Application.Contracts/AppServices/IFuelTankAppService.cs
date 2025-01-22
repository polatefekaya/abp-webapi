using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.FuelTank;

namespace Polat.CarFactory.AppServices;

public interface IFuelTankAppService
{
    public Task SetCapacity(SetFuelTankCapacityDto dto);
    public Task SetTankType(SetFuelTankTypeDto dto);
}
