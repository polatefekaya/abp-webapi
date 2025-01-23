using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Paint.Get;
using Polat.CarFactory.DTOs.UseCases.Paint.Response.Get;

namespace Polat.CarFactory.UseCases.Paint.Get;

public class GetPaintNameUseCase : IUseCase<GetPaintNameDto, GetPaintNameResponseDto>
{
    public Task<GetPaintNameResponseDto> ExecuteAsync(GetPaintNameDto dto)
    {
        throw new NotImplementedException();
    }
}
