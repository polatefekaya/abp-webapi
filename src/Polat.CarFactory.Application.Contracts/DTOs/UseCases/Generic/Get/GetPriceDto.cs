using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Generic.Get;

public record class GetPriceDto : BaseGuidDto
{
    public GetPriceDto(Guid id) : base(id)
    {
    }
}
