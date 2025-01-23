using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.FuelTank.Get;

public record class GetFuelTankCapacityDto : BaseGuidDto
{
    public GetFuelTankCapacityDto(Guid id) : base(id)
    {
    }
}
