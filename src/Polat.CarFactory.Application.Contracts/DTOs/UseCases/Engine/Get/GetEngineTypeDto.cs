using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Engine.Get;

public record class GetEngineTypeDto : BaseGuidDto
{
    public GetEngineTypeDto(Guid id) : base(id)
    {
    }
}
