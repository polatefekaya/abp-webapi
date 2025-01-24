using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Engine.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Set;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.UseCases;

namespace Polat.CarFactory.AppServices;

public class EngineAppService : IEngineAppService
{
    private readonly IGenericAppService _genericAppService;

    private readonly IUseCase<GetEngineDto, GetEngineResponseDto> _getEngineUseCase;
    private readonly IUseCase<GetEngineCylinderDto, GetEngineCylinderResponseDto> _getEngineCylinderUseCase;
    private readonly IUseCase<GetEngineTypeDto, GetEngineTypeResponseDto> _getEngineTypeUseCase;
    private readonly IUseCase<GetEngineHorsePowerDto, GetEngineHorsePowerResponseDto> _getEngineHorsePowerUseCase;
    private readonly IUseCase<GetEngineKwDto, GetEngineKwResponseDto> _getEngineKwUseCase;
    private readonly IUseCase<GetEngineTorqueDto, GetEngineTorqueResponseDto> _getEngineTorqueUseCase;

    private readonly IUseCase<SetEngineCylinderDto> _setEngineCylinderUseCase;
    private readonly IUseCase<SetEngineTypeDto> _setEngineTypeUseCase;
    private readonly IUseCase<SetEngineHorsePowerDto> _setEngineHorsePowerUseCase;
    private readonly IUseCase<SetEngineKwDto> _setEngineKwUseCase;
    private readonly IUseCase<SetEngineTorqueDto> _setEngineTorqueUseCase;
    public EngineAppService(
            IGenericAppService genericAppService,
            IUseCase<GetEngineDto, GetEngineResponseDto> getEngineUseCase,
            IUseCase<GetEngineCylinderDto, GetEngineCylinderResponseDto> getEngineCylinderUseCase,
            IUseCase<GetEngineTypeDto, GetEngineTypeResponseDto> getEngineTypeUseCase,
            IUseCase<GetEngineHorsePowerDto, GetEngineHorsePowerResponseDto> getEngineHorsePowerUseCase,
            IUseCase<GetEngineKwDto, GetEngineKwResponseDto> getEngineKwUseCase,
            IUseCase<GetEngineTorqueDto, GetEngineTorqueResponseDto> getEngineTorqueUseCase,
            IUseCase<SetEngineCylinderDto> setEngineCylinderUseCase,
            IUseCase<SetEngineTypeDto> setEngineTypeUseCase,
            IUseCase<SetEngineHorsePowerDto> setEngineHorsePowerUseCase,
            IUseCase<SetEngineKwDto> setEngineKwUseCase,
            IUseCase<SetEngineTorqueDto> setEngineTorqueUseCase
        )
    {
        _genericAppService = genericAppService;

        _getEngineUseCase = getEngineUseCase;
        _getEngineCylinderUseCase = getEngineCylinderUseCase;
        _getEngineTypeUseCase = getEngineTypeUseCase;
        _getEngineHorsePowerUseCase = getEngineHorsePowerUseCase;
        _getEngineKwUseCase = getEngineKwUseCase;
        _getEngineTorqueUseCase = getEngineTorqueUseCase;

        _setEngineCylinderUseCase = setEngineCylinderUseCase;
        _setEngineTypeUseCase = setEngineTypeUseCase;
        _setEngineHorsePowerUseCase = setEngineHorsePowerUseCase;
        _setEngineKwUseCase = setEngineKwUseCase;
        _setEngineTorqueUseCase = setEngineTorqueUseCase;
    }
    public async Task<GetEngineCylinderResponseDto> GetCylinder(GetEngineCylinderDto dto)
    {
        return await _getEngineCylinderUseCase.ExecuteAsync(dto);
    }

    public async Task<GetEngineResponseDto> GetEngine(GetEngineDto dto)
    {
        return await _getEngineUseCase.ExecuteAsync(dto);
    }

    public async Task<GetEngineTypeResponseDto> GetEngineType(GetEngineTypeDto dto)
    {
        return await _getEngineTypeUseCase.ExecuteAsync(dto);
    }

    public async Task<GetEngineHorsePowerResponseDto> GetHorsePower(GetEngineHorsePowerDto dto)
    {
        return await _getEngineHorsePowerUseCase.ExecuteAsync(dto);
    }

    public async Task<GetEngineKwResponseDto> GetKw(GetEngineKwDto dto)
    {
        return await _getEngineKwUseCase.ExecuteAsync(dto);
    }

    public async Task<GetPriceResponseDto> GetPrice(GetPriceDto dto)
    {
        return await _genericAppService.GetPrice(dto);
    }

    public async Task<GetEngineTorqueResponseDto> GetTorque(GetEngineTorqueDto dto)
    {
        return await _getEngineTorqueUseCase.ExecuteAsync(dto);
    }

    public async Task<GetVolumeResponseDto> GetVolume(GetVolumeDto dto)
    {
        return await _genericAppService.GetVolume(dto);
    }

    public async Task<GetWeightResponseDto> GetWeight(GetWeightDto dto)
    {
        return await _genericAppService.GetWeight(dto);
    }

    public async Task SetCylinder(SetEngineCylinderDto dto)
    {
        await _setEngineCylinderUseCase.ExecuteAsync(dto);
    }

    public async Task SetEngineType(SetEngineTypeDto dto)
    {
        await _setEngineTypeUseCase.ExecuteAsync(dto);
    }

    public async Task SetHorsePower(SetEngineHorsePowerDto dto)
    {
        await _setEngineHorsePowerUseCase.ExecuteAsync(dto);
    }

    public async Task SetKw(SetEngineKwDto dto)
    {
        await _setEngineKwUseCase.ExecuteAsync(dto);
    }

    public async Task SetPrice(SetPriceDto dto)
    {
        await _genericAppService.SetPrice(dto);
    }

    public async Task SetTorque(SetEngineTorqueDto dto)
    {
        await _setEngineTorqueUseCase.ExecuteAsync(dto);
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
