using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Generic;
using Polat.CarFactory.DTOs.UseCases.Part;

namespace Polat.CarFactory.Controllers.v1;

public class PartController : CarFactoryController, IPartAppService
{
    public Task SetAxle(SetPartAxleDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetCategory(SetPartCategoryDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetMaterial(SetMaterialDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetPrice(SetPriceDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetVolume(SetVolumeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetWeight(SetWeightDto dto)
    {
        throw new NotImplementedException();
    }
}
