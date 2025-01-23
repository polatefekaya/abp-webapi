using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.UseCases;

namespace Polat.CarFactory.AppServices.Generic;

public class GenericAppService : IGenericAppService
{
    private readonly IUseCase<GetMaterialDto, GetMaterialResponseDto> _getMaterialUseCase;
    private readonly IUseCase<GetPriceDto, GetPriceResponseDto> _getPriceUseCase;
    private readonly IUseCase<GetWeightDto, GetWeightResponseDto> _getWeightUseCase;
    private readonly IUseCase<GetVolumeDto, GetVolumeResponseDto> _getVolumeUseCase;

    private readonly IUseCase<SetMaterialDto> _setMaterialUseCase;
    private readonly IUseCase<SetPriceDto> _setPriceUseCase;
    private readonly IUseCase<SetWeightDto> _setWeightUseCase;
    private readonly IUseCase<SetVolumeDto> _setVolumeUseCase;

    public GenericAppService(
        IUseCase<GetMaterialDto, GetMaterialResponseDto> getMaterialUseCase, 
        IUseCase<GetPriceDto, GetPriceResponseDto> getPriceUseCase, 
        IUseCase<GetWeightDto, GetWeightResponseDto> getWeightUseCase, 
        IUseCase<GetVolumeDto, GetVolumeResponseDto> getVolumeUseCase,
        IUseCase<SetMaterialDto> setMaterialUseCase,
        IUseCase<SetPriceDto> setPriceUseCase,
        IUseCase<SetWeightDto> setWeightUseCase,
        IUseCase<SetVolumeDto> setVolumeUseCase){
            _getMaterialUseCase = getMaterialUseCase;
            _getPriceUseCase = getPriceUseCase;
            _getWeightUseCase = getWeightUseCase;
            _getVolumeUseCase = getVolumeUseCase;

            _setMaterialUseCase = setMaterialUseCase;
            _setPriceUseCase = setPriceUseCase;
            _setWeightUseCase = setWeightUseCase;
            _setVolumeUseCase = setVolumeUseCase;
        }
    
    public async Task<GetMaterialResponseDto> GetMaterial(GetMaterialDto dto)
    {
        return await _getMaterialUseCase.ExecuteAsync(dto);
    }

    public async Task<GetPriceResponseDto> GetPrice(GetPriceDto dto)
    {
        return await _getPriceUseCase.ExecuteAsync(dto);
    }

    public async Task<GetVolumeResponseDto> GetVolume(GetVolumeDto dto)
    {
        return await _getVolumeUseCase.ExecuteAsync(dto);
    }

    public async Task<GetWeightResponseDto> GetWeight(GetWeightDto dto)
    {
        return await _getWeightUseCase.ExecuteAsync(dto);
    }

    public async Task SetMaterial(SetMaterialDto dto)
    {
        await _setMaterialUseCase.ExecuteAsync(dto);
    }

    public async Task SetPrice(SetPriceDto dto)
    {
        await _setPriceUseCase.ExecuteAsync(dto);
    }

    public async Task SetVolume(SetVolumeDto dto)
    {
        await _setVolumeUseCase.ExecuteAsync(dto);
    }

    public async Task SetWeight(SetWeightDto dto)
    {
        await _setWeightUseCase.ExecuteAsync(dto);
    }
}
