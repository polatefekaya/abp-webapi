using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Body.Get;
using Polat.CarFactory.DTOs.UseCases.Body.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Body.Set;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.UseCases;

namespace Polat.CarFactory.Controllers.v1;

public class BodyController : CarFactoryController, IBodyAppService
{
    private readonly IUseCase<SetBodyTypeDto> _setBodyTypeUseCase;
    private readonly IUseCase<GetBodyCdDto, decimal> _getBodyCdUseCase;
    public BodyController(IUseCase<SetBodyTypeDto> setBodyTypeUseCase, IUseCase<GetBodyCdDto, decimal> getBodyCdUseCase)
    {
        _setBodyTypeUseCase = setBodyTypeUseCase;
        _getBodyCdUseCase = getBodyCdUseCase;
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

    public Task<GetMaterialResponseDto> GetMaterial(GetMaterialDto dto)
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
