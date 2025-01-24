using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Get;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Response.Get;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Set;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.UseCases;

namespace Polat.CarFactory.AppServices;

public class FuelTankAppService : IFuelTankAppService
{
    private readonly IGenericAppService _genericAppService;

    private readonly IUseCase<GetFuelTankDto, GetFuelTankResponseDto> _getTankUseCase;
    private readonly IUseCase<GetFuelTankCapacityDto, GetFuelTankCapacityResponseDto> _getTankCapacityUseCase;
    private readonly IUseCase<GetFuelTankTypeDto, GetFuelTankTypeResponseDto> _getTankTypeUseCase;

    private readonly IUseCase<SetFuelTankCapacityDto> _setTankCapacityUseCase;
    private readonly IUseCase<SetFuelTankTypeDto> _setTankTypeUseCase;

    public FuelTankAppService(
            IGenericAppService genericAppService,
            IUseCase<GetFuelTankDto, GetFuelTankResponseDto> getTankUseCase,
            IUseCase<GetFuelTankCapacityDto, GetFuelTankCapacityResponseDto> getTankCapacityUseCase,
            IUseCase<GetFuelTankTypeDto, GetFuelTankTypeResponseDto> getTankTypeUseCase,
            IUseCase<SetFuelTankCapacityDto> setTankCapacityUseCase,
            IUseCase<SetFuelTankTypeDto> setTankTypeUseCase
        )
    {
        _genericAppService = genericAppService;

        _getTankUseCase = getTankUseCase;
        _getTankCapacityUseCase = getTankCapacityUseCase;
        _getTankTypeUseCase = getTankTypeUseCase;

        _setTankCapacityUseCase = setTankCapacityUseCase;
        _setTankTypeUseCase = setTankTypeUseCase;
    }

    public async Task<GetFuelTankCapacityResponseDto> GetCapacity(GetFuelTankCapacityDto dto)
    {
        return await _getTankCapacityUseCase.ExecuteAsync(dto);
    }

    public async Task<GetPriceResponseDto> GetPrice(GetPriceDto dto)
    {
        return await _genericAppService.GetPrice(dto);
    }

    public async Task<GetFuelTankResponseDto> GetTank(GetFuelTankDto dto)
    {
        return await _getTankUseCase.ExecuteAsync(dto);
    }

    public async Task<GetFuelTankTypeResponseDto> GetTankType(GetFuelTankTypeDto dto)
    {
        return await _getTankTypeUseCase.ExecuteAsync(dto);
    }

    public async Task SetCapacity(SetFuelTankCapacityDto dto)
    {
        await _setTankCapacityUseCase.ExecuteAsync(dto);
    }

    public async Task SetPrice(SetPriceDto dto)
    {
        await _genericAppService.SetPrice(dto);
    }

    public async Task SetTankType(SetFuelTankTypeDto dto)
    {
        await _setTankTypeUseCase.ExecuteAsync(dto);
    }
}
