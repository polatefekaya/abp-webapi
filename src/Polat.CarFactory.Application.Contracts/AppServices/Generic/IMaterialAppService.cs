using System;
using System.Threading.Tasks;
using Polat.CarFactory.Enums;

namespace Polat.CarFactory.AppServices.Generic;

public interface IMaterialAppService
{
    public Task SetMaterial(Guid id, MaterialEnum material);
}
