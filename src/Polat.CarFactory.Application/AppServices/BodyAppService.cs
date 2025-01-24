using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Body.Get;
using Polat.CarFactory.DTOs.UseCases.Body.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Body.Set;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.UseCases;

namespace Polat.CarFactory.AppServices;

public class BodyAppService : IBodyAppService
{
    private readonly IGenericAppService _genericAppService;

    private readonly IUseCase<GetBodyDto, GetBodyResponseDto> _getBodyUseCase;
    private readonly IUseCase<GetBodyTypeDto, GetBodyTypeResponseDto> _getBodyTypeUseCase;
    private readonly IUseCase<GetBodyCdDto, GetBodyCdResponseDto> _getBodyCdUseCase;
    private readonly IUseCase<GetBodyDoorCountDto, GetBodyDoorCountResponseDto> _getBodyDoorCountUseCase;

    private readonly IUseCase<SetBodyDoorCountDto> _setBodyDoorCountUseCase;
    private readonly IUseCase<SetBodyTypeDto> _setBodyTypeUseCase;
    private readonly IUseCase<SetBodyCdDto> _setBodyCdUseCase;

    public BodyAppService(
        IGenericAppService genericAppService,
        IUseCase<GetBodyDto, GetBodyResponseDto> getBodyUseCase,
        IUseCase<GetBodyTypeDto, GetBodyTypeResponseDto> getBodyTypeUseCase,
        IUseCase<GetBodyCdDto, GetBodyCdResponseDto> getBodyCdUseCase,
        IUseCase<GetBodyDoorCountDto, GetBodyDoorCountResponseDto> getBodyDoorCountUseCase,
        IUseCase<SetBodyDoorCountDto> setBodyDoorCountUseCase,
        IUseCase<SetBodyTypeDto> setBodyTypeUseCase,
        IUseCase<SetBodyCdDto> setBodyCdUseCase
    ){
        _genericAppService = genericAppService;

        _getBodyUseCase = getBodyUseCase;
        _getBodyCdUseCase = getBodyCdUseCase;
        _getBodyTypeUseCase = getBodyTypeUseCase;
        _getBodyDoorCountUseCase = getBodyDoorCountUseCase;

        _setBodyCdUseCase = setBodyCdUseCase;
        _setBodyDoorCountUseCase = setBodyDoorCountUseCase;
        _setBodyTypeUseCase = setBodyTypeUseCase;
    }
    public async Task<GetBodyResponseDto> GetBody(GetBodyDto dto)
    {
        return await _getBodyUseCase.ExecuteAsync(dto);
    }

    public async Task<GetBodyTypeResponseDto> GetBodyType(GetBodyTypeDto dto)
    {
        return await _getBodyTypeUseCase.ExecuteAsync(dto); 
    }

    public async Task<GetBodyCdResponseDto> GetCd(GetBodyCdDto dto)
    {
        return await _getBodyCdUseCase.ExecuteAsync(dto);
    }

    public async Task<GetBodyDoorCountResponseDto> GetDoorCount(GetBodyDoorCountDto dto)
    {
        return await _getBodyDoorCountUseCase.ExecuteAsync(dto);
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

    public async Task SetBodyType(SetBodyTypeDto dto)
    {
        await _setBodyTypeUseCase.ExecuteAsync(dto);
    }

    public async Task SetCd(SetBodyCdDto dto)
    {
        await _setBodyCdUseCase.ExecuteAsync(dto);
    }

    public async Task SetDoorCount(SetBodyDoorCountDto dto)
    {
        await _setBodyDoorCountUseCase.ExecuteAsync(dto);
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
