using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Generic.Get;

public record class GetWeightDto : BaseGuidDto
{
    public GetWeightDto(Guid id) : base(id)
    {
    }
}
