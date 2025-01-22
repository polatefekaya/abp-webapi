using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Generic;
using Polat.CarFactory.Enums;

namespace Polat.CarFactory.AppServices.Generic;

public interface IMaterialAppService
{
    public Task SetMaterial(SetMaterialDto dto);
}
