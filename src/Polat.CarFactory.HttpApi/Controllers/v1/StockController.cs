using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.DTOs.UseCases.Stock.Get;
using Polat.CarFactory.DTOs.UseCases.Stock.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Stock.Set;

namespace Polat.CarFactory.Controllers.v1;

public class StockController : CarFactoryController
{
    private IStockAppService _stockAppService;

    public StockController(IStockAppService stockAppService){
        _stockAppService = stockAppService;
    }

    [HttpPut] //AddCount
    public async Task<IActionResult> Count(AddStockCountDto dto)
    {
        await _stockAppService.AddCount(dto);
        return Ok();
    }

    [HttpGet] //GetCount
    public async Task<ActionResult<GetStockCountResponseDto>> Count(GetStockCountDto dto)
    {
        var response = await _stockAppService.GetCount(dto);
        return Ok(response);
    }

    [HttpGet] //GetStock
    public async Task<ActionResult<GetStockResponseDto>> Stock(GetStockDto dto)
    {
        var response = await _stockAppService.GetStock(dto);
        return Ok(response);
    }

    [HttpDelete] //RemoveCount
    public async Task<IActionResult> Count(RemoveStockCountDto dto)
    {
        await _stockAppService.RemoveCount(dto);
        return Ok();
    }

    [HttpPost] //SetCount
    public async Task<IActionResult> Count(SetStockCountDto dto)
    {
        await _stockAppService.SetCount(dto);
        return Ok();
    }
}
