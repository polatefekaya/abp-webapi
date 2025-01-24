using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Get;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Response.Get;
using Polat.CarFactory.DTOs.UseCases.FuelTank.Set;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;

namespace Polat.CarFactory.Controllers.v1;

public class FuelTankController : CarFactoryController
{
    private readonly IFuelTankAppService _fuelTankAppService;

    public FuelTankController(IFuelTankAppService fuelTankAppService){
        _fuelTankAppService = fuelTankAppService;
    }

    [HttpGet]
    public async Task<ActionResult<GetFuelTankCapacityResponseDto>> Capacity(GetFuelTankCapacityDto dto)
    {
        var response = await _fuelTankAppService.GetCapacity(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetPriceResponseDto>> Price(GetPriceDto dto)
    {
        var response = await _fuelTankAppService.GetPrice(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetFuelTankResponseDto>> Tank(GetFuelTankDto dto)
    {
        var response = await _fuelTankAppService.GetTank(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetFuelTankTypeResponseDto>> TankType(GetFuelTankTypeDto dto)
    {
        var response = await _fuelTankAppService.GetTankType(dto);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Capacity(SetFuelTankCapacityDto dto)
    {
        await _fuelTankAppService.SetCapacity(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Price(SetPriceDto dto)
    {
        await _fuelTankAppService.SetPrice(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> TankType(SetFuelTankTypeDto dto)
    {
        await _fuelTankAppService.SetTankType(dto);
        return Ok();
    }
}
