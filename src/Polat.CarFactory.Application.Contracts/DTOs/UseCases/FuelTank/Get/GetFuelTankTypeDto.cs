using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.FuelTank.Get;

public record class GetFuelTankTypeDto : BaseGuidDto
{
    public GetFuelTankTypeDto(Guid id) : base(id)
    {
    }
}
