using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Generic;

namespace Polat.CarFactory.AppServices.Generic;

public interface IWeightAppService
{
    public Task SetWeight(SetWeightDto dto);
}
