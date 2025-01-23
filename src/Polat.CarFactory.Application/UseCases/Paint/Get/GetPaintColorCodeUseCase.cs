using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Paint.Get;
using Polat.CarFactory.DTOs.UseCases.Paint.Response.Get;

namespace Polat.CarFactory.UseCases.Paint.Get;

public class GetPaintColorCodeUseCase : IUseCase<GetPaintColorCodeDto, GetPaintColorCodeResponseDto>
{
    public Task<GetPaintColorCodeResponseDto> ExecuteAsync(GetPaintColorCodeDto dto)
    {
        throw new NotImplementedException();
    }
}
