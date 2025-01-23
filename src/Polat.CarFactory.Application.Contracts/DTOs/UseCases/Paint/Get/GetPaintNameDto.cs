using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Paint.Get;

public record class GetPaintNameDto : BaseGuidDto
{
    public GetPaintNameDto(Guid id) : base(id)
    {
    }
}
