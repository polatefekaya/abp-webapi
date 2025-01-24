using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Engine.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Engine.Set;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;

namespace Polat.CarFactory.Controllers.v1;

public class EngineController : CarFactoryController
{
    private IEngineAppService _engineAppService;
    public EngineController(IEngineAppService engineAppService)
    {
        _engineAppService = engineAppService;
    }

    [HttpGet]
    public async Task<ActionResult<GetEngineCylinderResponseDto>> Cylinder(GetEngineCylinderDto dto)
    {
        var response = await _engineAppService.GetCylinder(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetEngineResponseDto>> Engine(GetEngineDto dto)
    {
        var response = await _engineAppService.GetEngine(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetEngineTypeResponseDto>> EngineType(GetEngineTypeDto dto)
    {
        var response = await _engineAppService.GetEngineType(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetEngineHorsePowerResponseDto>> HorsePower(GetEngineHorsePowerDto dto)
    {
        var response = await _engineAppService.GetHorsePower(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetEngineKwResponseDto>> Kw(GetEngineKwDto dto)
    {
        var response = await _engineAppService.GetKw(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetPriceResponseDto>> Price(GetPriceDto dto)
    {
        var response = await _engineAppService.GetPrice(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetEngineTorqueResponseDto>> Torque(GetEngineTorqueDto dto)
    {
        var response = await _engineAppService.GetTorque(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetVolumeResponseDto>> Volume(GetVolumeDto dto)
    {
        var response = await _engineAppService.GetVolume(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetWeightResponseDto>> Weight(GetWeightDto dto)
    {
        var response = await _engineAppService.GetWeight(dto);
        return Ok(response);
    }


    [HttpPost]
    public async Task<IActionResult> Cylinder(SetEngineCylinderDto dto)
    {
        await _engineAppService.SetCylinder(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> EngineType(SetEngineTypeDto dto)
    {
        await _engineAppService.SetEngineType(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> HorsePower(SetEngineHorsePowerDto dto)
    {
        await _engineAppService.SetHorsePower(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Kw(SetEngineKwDto dto)
    {
        await _engineAppService.SetKw(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Price(SetPriceDto dto)
    {
        await _engineAppService.SetPrice(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Torque(SetEngineTorqueDto dto)
    {
        await _engineAppService.SetTorque(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Volume(SetVolumeDto dto)
    {
        await _engineAppService.SetVolume(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Weight(SetWeightDto dto)
    {
        await _engineAppService.SetWeight(dto);
        return Ok();
    }
}
