using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.DTOs.UseCases.Paint.Get;
using Polat.CarFactory.DTOs.UseCases.Paint.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Paint.Set;

namespace Polat.CarFactory.Controllers.v1;

public class PaintController : CarFactoryController
{
    private readonly IPaintAppService _paintAppService;

    public PaintController(IPaintAppService paintAppService){
        _paintAppService = paintAppService;
    }
    [HttpGet]
    public async Task<ActionResult<GetPaintColorCodeResponseDto>> ColorCode(GetPaintColorCodeDto dto)
    {
        var response = await _paintAppService.GetColorCode(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetPaintNameResponseDto>> Name(GetPaintNameDto dto)
    {
        var response = await _paintAppService.GetName(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetPaintResponseDto>> Paint(GetPaintDto dto)
    {
        var response = await _paintAppService.GetPaint(dto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetPriceResponseDto>> Price(GetPriceDto dto)
    {
        var response = await _paintAppService.GetPrice(dto);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> ColorCode(SetPaintColorCodeDto dto)
    {
        await _paintAppService.SetColorCode(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Name(SetPaintNameDto dto)
    {
        await _paintAppService.SetName(dto);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Price(SetPriceDto dto)
    {
        await _paintAppService.SetPrice(dto);
        return Ok();
    }
}
