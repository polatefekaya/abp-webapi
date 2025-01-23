using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Paint.Get;
using Polat.CarFactory.DTOs.UseCases.Paint.Response.Get;

namespace Polat.CarFactory.UseCases.Paint.Get;

public class GetPaintUseCase : IUseCase<GetPaintDto, GetPaintResponseDto>
{
    public Task<GetPaintResponseDto> ExecuteAsync(GetPaintDto dto)
    {
        throw new NotImplementedException();
    }
}
