using System;
using System.Threading.Tasks;

namespace Polat.CarFactory.AppServices.Generic;

public interface IWeightAppService
{
    public Task SetWeight(Guid bodyId, int weight);
}
