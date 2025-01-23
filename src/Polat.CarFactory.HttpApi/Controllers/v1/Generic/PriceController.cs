using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;

namespace Polat.CarFactory.Controllers.v1.Generic;

public abstract class PriceController : CarFactoryController
{
    private readonly IGenericAppService _genericAppService;
    public PriceController(IGenericAppService genericAppService){
        _genericAppService = genericAppService;
    }

    [HttpGet]
    public async Task<ActionResult<GetPriceResponseDto>> Price(GetPriceDto dto)
    {
        return Ok(await _genericAppService.GetPrice(dto));
    }
    
    [HttpPost]
    public async Task<IActionResult> Price(SetPriceDto dto)
    {
        await _genericAppService.SetPrice(dto);
        return Ok();
    }
}
