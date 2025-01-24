using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Stock.Get;
using Polat.CarFactory.DTOs.UseCases.Stock.Response.Get;
using Polat.CarFactory.DTOs.UseCases.Stock.Set;
using Polat.CarFactory.UseCases;

namespace Polat.CarFactory.AppServices;

public class StockAppService : IStockAppService
{
    private readonly IUseCase<GetStockCountDto, GetStockCountResponseDto> _getStockCountUseCase;
    private readonly IUseCase<GetStockDto, GetStockResponseDto> _getStockUseCase;

    private readonly IUseCase<AddStockCountDto> _addStockCountUseCase;
    private readonly IUseCase<SetStockCountDto> _setStockCountUseCase;
    private readonly IUseCase<RemoveStockCountDto> _removeStockCountUseCase;

    public StockAppService(
        IUseCase<GetStockDto, GetStockResponseDto> getStockUseCase,
        IUseCase<GetStockCountDto, GetStockCountResponseDto> getStockCountUseCase,
        IUseCase<AddStockCountDto> addStockCountUseCase,
        IUseCase<SetStockCountDto> setStockCountUseCase,
        IUseCase<RemoveStockCountDto> removeStockCountUseCase
    ){
        _getStockUseCase = getStockUseCase;
        _getStockCountUseCase = getStockCountUseCase;

        _addStockCountUseCase = addStockCountUseCase;
        _setStockCountUseCase = setStockCountUseCase;
        _removeStockCountUseCase = removeStockCountUseCase;
    }
    public async Task AddCount(AddStockCountDto dto)
    {
        await _addStockCountUseCase.ExecuteAsync(dto); 
    }

    public async Task<GetStockCountResponseDto> GetCount(GetStockCountDto dto)
    {
        return await _getStockCountUseCase.ExecuteAsync(dto);
    }

    public async Task<GetStockResponseDto> GetStock(GetStockDto dto)
    {
        return await _getStockUseCase.ExecuteAsync(dto);
    }

    public async Task RemoveCount(RemoveStockCountDto dto)
    {
        await _removeStockCountUseCase.ExecuteAsync(dto);
    }

    public async Task SetCount(SetStockCountDto dto)
    {
        await _setStockCountUseCase.ExecuteAsync(dto);
    }
}
