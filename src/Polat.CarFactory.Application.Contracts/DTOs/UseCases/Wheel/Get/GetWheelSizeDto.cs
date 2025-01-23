using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Wheel.Get;

public record class GetWheelSizeDto : BaseGuidDto
{
    public GetWheelSizeDto(Guid id) : base(id)
    {
    }
}
