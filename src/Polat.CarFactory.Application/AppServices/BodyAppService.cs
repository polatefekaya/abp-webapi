using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Body.Get;
using Polat.CarFactory.DTOs.UseCases.Body.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Body.Set;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;

namespace Polat.CarFactory.AppServices;

public class BodyAppService : IBodyAppService
{
    private readonly IGenericAppService _genericAppService;
    public BodyAppService(IGenericAppService genericAppService){
        _genericAppService = genericAppService;
    }
    public Task<GetBodyResponseDto> GetBody(GetBodyDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetBodyTypeResponseDto> GetBodyType(GetBodyTypeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetBodyCdResponseDto> GetCd(GetBodyCdDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<GetBodyDoorCountResponseDto> GetDoorCount(GetBodyDoorCountDto dto)
    {
        throw new NotImplementedException();
    }

    public async Task<GetMaterialResponseDto> GetMaterial(GetMaterialDto dto)
    {
        return await _genericAppService.GetMaterial(dto);
    }

    public async Task<GetPriceResponseDto> GetPrice(GetPriceDto dto)
    {
        return await _genericAppService.GetPrice(dto);
    }

    public async Task<GetVolumeResponseDto> GetVolume(GetVolumeDto dto)
    {
        return await _genericAppService.GetVolume(dto);
    }

    public async Task<GetWeightResponseDto> GetWeight(GetWeightDto dto)
    {
        return await _genericAppService.GetWeight(dto);
    }

    public Task SetBodyType(SetBodyTypeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetCd(SetBodyCdDto dto)
    {
        throw new NotImplementedException();
    }

    public Task SetDoorCount(SetBodyDoorCountDto dto)
    {
        throw new NotImplementedException();
    }

    public async Task SetMaterial(SetMaterialDto dto)
    {
        await _genericAppService.SetMaterial(dto);
    }

    public async Task SetPrice(SetPriceDto dto)
    {
        await _genericAppService.SetPrice(dto);
    }

    public async Task SetVolume(SetVolumeDto dto)
    {
        await _genericAppService.SetVolume(dto);
    }

    public async Task SetWeight(SetWeightDto dto)
    {
        await _genericAppService.SetWeight(dto);
    }
}
