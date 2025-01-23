using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Paint.Get;

public record class GetPaintColorCodeDto : BaseGuidDto
{
    public GetPaintColorCodeDto(Guid id) : base(id)
    {
    }
}
