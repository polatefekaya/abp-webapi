using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Body.Get;
using Polat.CarFactory.DTOs.UseCases.Body.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Body.Set;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.UseCases;

namespace Polat.CarFactory.Controllers.v1;

public class BodyController : CarFactoryController
{
    private readonly IBodyAppService _bodyAppService;
    public BodyController(IBodyAppService bodyAppService)
    {
        _bodyAppService = bodyAppService;
    }

    [HttpGet]
    public async Task<ActionResult<GetBodyResponseDto>> Body(GetBodyDto dto)
    {
        GetBodyResponseDto response = await _bodyAppService.GetBody(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetBodyTypeResponseDto>> BodyType(GetBodyTypeDto dto)
    {
        GetBodyTypeResponseDto response = await _bodyAppService.GetBodyType(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetBodyCdResponseDto>> Cd(GetBodyCdDto dto)
    {
        GetBodyCdResponseDto response = await _bodyAppService.GetCd(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetBodyDoorCountResponseDto>> DoorCount(GetBodyDoorCountDto dto)
    {
        GetBodyDoorCountResponseDto response = await _bodyAppService.GetDoorCount(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetMaterialResponseDto>> Material(GetMaterialDto dto)
    {
        GetMaterialResponseDto response = await _bodyAppService.GetMaterial(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetPriceResponseDto>> Price(GetPriceDto dto)
    {
        GetPriceResponseDto response = await _bodyAppService.GetPrice(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetVolumeResponseDto>> Volume(GetVolumeDto dto)
    {
        GetVolumeResponseDto response = await _bodyAppService.GetVolume(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetWeightResponseDto>> Weight(GetWeightDto dto)
    {
        GetWeightResponseDto response = await _bodyAppService.GetWeight(dto);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> BodyType(SetBodyTypeDto dto)
    {
        await _bodyAppService.SetBodyType(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Cd(SetBodyCdDto dto)
    {
        await _bodyAppService.SetCd(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> DoorCount(SetBodyDoorCountDto dto)
    {
        await _bodyAppService.SetDoorCount(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Material(SetMaterialDto dto)
    {
        await _bodyAppService.SetMaterial(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Price(SetPriceDto dto)
    {
        await _bodyAppService.SetPrice(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Volume(SetVolumeDto dto)
    {
        await _bodyAppService.SetVolume(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Weight(SetWeightDto dto)
    {
        await _bodyAppService.SetWeight(dto);
        return Ok();
    }
}
