using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Engine.Get;

public record class GetEngineHorsePowerDto : BaseGuidDto
{
    public GetEngineHorsePowerDto(Guid id) : base(id)
    {
    }
}
