using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.DTOs.UseCases.Part.Get;
using Polat.CarFactory.DTOs.UseCases.Part.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Part.Set;

namespace Polat.CarFactory.Controllers.v1;

public class PartController : CarFactoryController
{
    private readonly IPartAppService _partAppService;

    public PartController(IPartAppService partAppService){
        _partAppService = partAppService;
    }

    [HttpGet]
    public async Task<ActionResult<GetPartAxleResponseDto>> Axle(GetPartAxleDto dto)
    {
        var response = await _partAppService.GetAxle(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetPartCategoryResponseDto>> Category(GetPartCategoryDto dto)
    {
        var response = await _partAppService.GetCategory(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetMaterialResponseDto>> Material(GetMaterialDto dto)
    {
        var response = await _partAppService.GetMaterial(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetPartResponseDto>> Part(GetPartDto dto)
    {
        var response = await _partAppService.GetPart(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetPriceResponseDto>> Price(GetPriceDto dto)
    {
        var response = await _partAppService.GetPrice(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetVolumeResponseDto>> Volume(GetVolumeDto dto)
    {
        var response = await _partAppService.GetVolume(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetWeightResponseDto>> Weight(GetWeightDto dto)
    {
        var response = await _partAppService.GetWeight(dto);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Axle(SetPartAxleDto dto)
    {
        await _partAppService.SetAxle(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Category(SetPartCategoryDto dto)
    {
        await _partAppService.SetCategory(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Material(SetMaterialDto dto)
    {
        await _partAppService.SetMaterial(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Price(SetPriceDto dto)
    {
        await _partAppService.SetPrice(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Volume(SetVolumeDto dto)
    {
        await _partAppService.SetVolume(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Weight(SetWeightDto dto)
    {
        await _partAppService.SetWeight(dto);
        return Ok();
    }
}
