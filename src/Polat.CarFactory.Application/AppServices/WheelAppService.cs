using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.DTOs.UseCases.Wheel.Get;
using Polat.CarFactory.DTOs.UseCases.Wheel.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Wheel.Set;
using Polat.CarFactory.UseCases;

namespace Polat.CarFactory.AppServices;

public class WheelAppService : IWheelAppService
{
    private readonly IGenericAppService _genericAppService;

    private readonly IUseCase<GetWheelSizeDto, GetWheelSizeResponseDto> _getWheelSizeUseCase;
    private readonly IUseCase<GetWheelDto, GetWheelResponseDto> _getWheelUseCase;

    private readonly IUseCase<SetWheelSizeDto> _setWheelSizeUseCase;

    public WheelAppService(
        IGenericAppService genericAppService,
        IUseCase<GetWheelDto, GetWheelResponseDto> getWheelUseCase,
        IUseCase<GetWheelSizeDto, GetWheelSizeResponseDto> getWheelSizeUseCase,
        IUseCase<SetWheelSizeDto> setWheelSizeUseCase
    ){
        _genericAppService = genericAppService;

        _getWheelUseCase = getWheelUseCase;
        _getWheelSizeUseCase = getWheelSizeUseCase;

        _setWheelSizeUseCase = setWheelSizeUseCase;
    }

    public async Task<GetMaterialResponseDto> GetMaterial(GetMaterialDto dto)
    {
        return await _genericAppService.GetMaterial(dto);
    }

    public async Task<GetPriceResponseDto> GetPrice(GetPriceDto dto)
    {
        return await _genericAppService.GetPrice(dto);
    }

    public async Task<GetWheelSizeResponseDto> GetSize(GetWheelSizeDto dto)
    {
        return await _getWheelSizeUseCase.ExecuteAsync(dto);
    }

    public async Task<GetWeightResponseDto> GetWeight(GetWeightDto dto)
    {
        return await _genericAppService.GetWeight(dto);
    }

    public async Task<GetWheelResponseDto> GetWheel(GetWheelDto dto)
    {
        return await _getWheelUseCase.ExecuteAsync(dto);
    }

    public async Task SetMaterial(SetMaterialDto dto)
    {
        await _genericAppService.SetMaterial(dto);
    }

    public async Task SetPrice(SetPriceDto dto)
    {
        await _genericAppService.SetPrice(dto);
    }

    public async Task SetSize(SetWheelSizeDto dto)
    {
        await _setWheelSizeUseCase.ExecuteAsync(dto);
    }

    public async Task SetWeight(SetWeightDto dto)
    {
        await _genericAppService.SetWeight(dto);
    }
}
