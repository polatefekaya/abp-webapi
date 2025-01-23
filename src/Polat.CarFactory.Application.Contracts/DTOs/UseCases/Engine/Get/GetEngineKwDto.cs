using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Engine.Get;

public record class GetEngineKwDto : BaseGuidDto
{
    public GetEngineKwDto(Guid id) : base(id)
    {
    }
}
