using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Generic.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Generic.Set;
using Polat.CarFactory.DTOs.UseCases.Paint.Get;
using Polat.CarFactory.DTOs.UseCases.Paint.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Paint.Set;
using Polat.CarFactory.UseCases;

namespace Polat.CarFactory.AppServices;

public class PaintAppService : IPaintAppService
{
    private readonly IGenericAppService _genericAppService;

    private readonly IUseCase<GetPaintColorCodeDto, GetPaintColorCodeResponseDto> _getPaintColorCodeUseCase;
    private readonly IUseCase<GetPaintDto, GetPaintResponseDto> _getPaintUseCase;
    private readonly IUseCase<GetPaintNameDto, GetPaintNameResponseDto> _getPaintNameUseCase;

    private readonly IUseCase<SetPaintColorCodeDto> _setPaintColorCodeUseCase;
    private readonly IUseCase<SetPaintNameDto> _setPaintNameUseCase;

    public PaintAppService(
        IGenericAppService genericAppService,
        IUseCase<GetPaintColorCodeDto, GetPaintColorCodeResponseDto> getPaintColorCodeUseCase,
        IUseCase<GetPaintDto, GetPaintResponseDto> getPaintUseCase,
        IUseCase<GetPaintNameDto, GetPaintNameResponseDto> getPaintNameUseCase,
        IUseCase<SetPaintColorCodeDto> setPaintColorCodeUseCase,
        IUseCase<SetPaintNameDto> setPaintNameUseCase
    ){
        _genericAppService = genericAppService;

        _getPaintUseCase = getPaintUseCase;
        _getPaintColorCodeUseCase = getPaintColorCodeUseCase;
        _getPaintNameUseCase = getPaintNameUseCase;

        _setPaintColorCodeUseCase = setPaintColorCodeUseCase;
        _setPaintNameUseCase = setPaintNameUseCase;
    }
    public async Task<GetPaintColorCodeResponseDto> GetColorCode(GetPaintColorCodeDto dto)
    {
        return await _getPaintColorCodeUseCase.ExecuteAsync(dto);
    }

    public async Task<GetPaintNameResponseDto> GetName(GetPaintNameDto dto)
    {
        return await _getPaintNameUseCase.ExecuteAsync(dto);
    }

    public async Task<GetPaintResponseDto> GetPaint(GetPaintDto dto)
    {
        return await _getPaintUseCase.ExecuteAsync(dto);
    }

    public async Task<GetPriceResponseDto> GetPrice(GetPriceDto dto)
    {
        return await _genericAppService.GetPrice(dto);
    }

    public async Task SetColorCode(SetPaintColorCodeDto dto)
    {
        await _setPaintColorCodeUseCase.ExecuteAsync(dto);
    }

    public async Task SetName(SetPaintNameDto dto)
    {
        await _setPaintNameUseCase.ExecuteAsync(dto);
    }

    public async Task SetPrice(SetPriceDto dto)
    {
        await _genericAppService.SetPrice(dto);
    }
}
