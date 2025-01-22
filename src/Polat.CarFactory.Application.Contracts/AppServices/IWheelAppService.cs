using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Wheel;

namespace Polat.CarFactory.AppServices;

public interface IWheelAppService : IMaterialAppService, IPriceAppService, IWeightAppService
{
    public Task SetSize(SetWheelSizeDto dto);
}
