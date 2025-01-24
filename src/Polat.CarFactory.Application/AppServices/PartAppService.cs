using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.DTOs.UseCases.Part.Get;
using Polat.CarFactory.DTOs.UseCases.Part.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Part.Set;
using Polat.CarFactory.UseCases;

namespace Polat.CarFactory.AppServices;

public class PartAppService : IPartAppService
{
    private readonly IGenericAppService _genericAppService;

    private readonly IUseCase<GetPartDto, GetPartResponseDto> _getPartUseCase;
    private readonly IUseCase<GetPartAxleDto, GetPartAxleResponseDto> _getPartAxleUseCase;
    private readonly IUseCase<GetPartCategoryDto, GetPartCategoryResponseDto> _getPartCategoryUseCase;

    private readonly IUseCase<SetPartCategoryDto> _setPartCategoryUseCase;
    private readonly IUseCase<SetPartAxleDto> _setPartAxleUseCase;

    public PartAppService(
        IGenericAppService genericAppService,
        IUseCase<GetPartDto, GetPartResponseDto> getPartUseCase,
        IUseCase<GetPartAxleDto, GetPartAxleResponseDto> getPartAxleUseCase,
        IUseCase<GetPartCategoryDto, GetPartCategoryResponseDto> getPartCategoryUseCase,
        IUseCase<SetPartCategoryDto> setPartCategoryUseCase,
        IUseCase<SetPartAxleDto> setPartAxleUseCase
    ){
        _genericAppService = genericAppService;

        _getPartUseCase = getPartUseCase;
        _getPartAxleUseCase = getPartAxleUseCase;
        _getPartCategoryUseCase = getPartCategoryUseCase;

        _setPartAxleUseCase = setPartAxleUseCase;
        _setPartCategoryUseCase = setPartCategoryUseCase;
    }
    public async Task<GetPartAxleResponseDto> GetAxle(GetPartAxleDto dto)
    {
        return await _getPartAxleUseCase.ExecuteAsync(dto);
    }

    public async Task<GetPartCategoryResponseDto> GetCategory(GetPartCategoryDto dto)
    {
        return await _getPartCategoryUseCase.ExecuteAsync(dto);
    }

    public async Task<GetMaterialResponseDto> GetMaterial(GetMaterialDto dto)
    {
        return await _genericAppService.GetMaterial(dto);
    }

    public async Task<GetPartResponseDto> GetPart(GetPartDto dto)
    {
        return await _getPartUseCase.ExecuteAsync(dto);
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

    public async Task SetAxle(SetPartAxleDto dto)
    {
        await _setPartAxleUseCase.ExecuteAsync(dto);
    }

    public async Task SetCategory(SetPartCategoryDto dto)
    {
        await _setPartCategoryUseCase.ExecuteAsync(dto);
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
