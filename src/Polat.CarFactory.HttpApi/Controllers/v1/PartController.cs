using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.DTOs.UseCases.Part.Get;
using Polat.CarFactory.DTOs.UseCases.Part.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Part.Set;

namespace Polat.CarFactory.Controllers.v1;

public class PartController : CarFactoryController, IPartAppService
{
    public Task<GetPartAxleResponseDto> GetAxle(GetPartAxleDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetPartCategoryResponseDto> GetCategory(GetPartCategoryDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetMaterialResponseDto> GetMaterial(GetMaterialDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetPartResponseDto> GetPart(GetPartDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetPriceResponseDto> GetPrice(GetPriceDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetVolumeResponseDto> GetVolume(GetVolumeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetWeightResponseDto> GetWeight(GetWeightDto dto)
    {
        throw new NotImplementedException();
    }

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
