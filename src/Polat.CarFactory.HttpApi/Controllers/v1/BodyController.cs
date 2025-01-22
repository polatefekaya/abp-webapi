using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Body;
using Polat.CarFactory.DTOs.UseCases.Generic;
using Polat.CarFactory.Enums;
using Polat.CarFactory.UseCases;
using Polat.CarFactory.ValueObjects;

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

    [HttpGet("cd")]
    public async Task<decimal> GetCd(GetBodyCdDto dto)
    {
        return await _getBodyCdUseCase.ExecuteAsync(dto);
    }

    public async Task SetBodyType(SetBodyTypeDto dto)
    {
        await _setBodyTypeUseCase.ExecuteAsync(dto);
    }

    [HttpPost("cd")]
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
