using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.DTOs.UseCases.Wheel.Get;
using Polat.CarFactory.DTOs.UseCases.Wheel.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Wheel.Set;

namespace Polat.CarFactory.Controllers.v1;

public class WheelController : CarFactoryController
{
    private readonly IWheelAppService _wheelAppService;

    public WheelController(IWheelAppService wheelAppService){
        _wheelAppService = wheelAppService;
    }

    [HttpGet]
    public async Task<ActionResult<GetMaterialResponseDto>> Material(GetMaterialDto dto)
    {
        var response = await _wheelAppService.GetMaterial(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetPriceResponseDto>> Price(GetPriceDto dto)
    {
        var response = await _wheelAppService.GetPrice(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetWheelSizeResponseDto>> Size(GetWheelSizeDto dto)
    {
        var response = await _wheelAppService.GetSize(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetWeightResponseDto>> Weight(GetWeightDto dto)
    {
        var response = await _wheelAppService.GetWeight(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetWheelResponseDto>> Wheel(GetWheelDto dto)
    {
        var response = await _wheelAppService.GetWheel(dto);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Material(SetMaterialDto dto)
    {
        await _wheelAppService.SetMaterial(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Price(SetPriceDto dto)
    {
        await _wheelAppService.SetPrice(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Size(SetWheelSizeDto dto)
    {
        await _wheelAppService.SetSize(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Weight(SetWeightDto dto)
    {
        await _wheelAppService.SetWeight(dto);
        return Ok();
    }
}
