using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.FuelTank;

namespace Polat.CarFactory.Controllers.v1;

public class FuelTankController : CarFactoryController, IFuelTankAppService
{
    public Task SetCapacity(SetFuelTankCapacityDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetTankType(SetFuelTankTypeDto dto)
    {
        throw new NotImplementedException();
    }
}
