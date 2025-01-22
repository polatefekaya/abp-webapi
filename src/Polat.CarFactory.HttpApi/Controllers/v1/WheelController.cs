using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Generic;
using Polat.CarFactory.DTOs.UseCases.Wheel;
using Polat.CarFactory.UseCases;

namespace Polat.CarFactory.Controllers.v1;

public class WheelController : CarFactoryController, IWheelAppService
{
    private readonly IUseCase<SetMaterialDto> _setMaterialUseCase;
    private readonly IUseCase<SetPriceDto> _setPriceUseCase;
    private readonly IUseCase<SetWheelSizeDto> _setWheelSizeUseCase;
    private readonly IUseCase<SetWeightDto> _setWeightUseCase;
    public WheelController(IUseCase<SetMaterialDto> setMaterialUseCase, IUseCase<SetPriceDto> setPriceUseCase, IUseCase<SetWheelSizeDto> setWheelSizeDto, IUseCase<SetWeightDto> setWeightUseCase){
        _setMaterialUseCase = setMaterialUseCase;
        _setPriceUseCase = setPriceUseCase;
        _setWheelSizeUseCase = setWheelSizeDto;
        _setWeightUseCase = setWeightUseCase;
    }
    public async Task SetMaterial(SetMaterialDto dto)
    {
        await _setMaterialUseCase.ExecuteAsync(dto);
    }

    public async Task SetPrice(SetPriceDto dto)
    {
        await _setPriceUseCase.ExecuteAsync(dto);
    }
    [HttpPost("size")]
    public async Task SetSize(SetWheelSizeDto dto)
    {
        await _setWheelSizeUseCase.ExecuteAsync(dto);
    }

    [HttpGet("size")]
    public async Task<ActionResult<string>> GetSize(){

        return "";
    }

    public async Task SetWeight(SetWeightDto dto)
    {
        await _setWeightUseCase.ExecuteAsync(dto);
    }
}
