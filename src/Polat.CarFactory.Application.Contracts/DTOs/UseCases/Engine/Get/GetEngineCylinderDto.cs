using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Engine.Get;

public record class GetEngineCylinderDto : BaseGuidDto
{
    public GetEngineCylinderDto(Guid id) : base(id)
    {
    }
}
