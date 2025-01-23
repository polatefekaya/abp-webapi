using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Part.Get;

public record class GetPartAxleDto : BaseGuidDto
{
    public GetPartAxleDto(Guid id) : base(id)
    {
    }
}
