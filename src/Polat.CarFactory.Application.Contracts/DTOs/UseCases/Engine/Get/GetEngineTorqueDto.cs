using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Engine.Get;

public record class GetEngineTorqueDto : BaseGuidDto
{
    public GetEngineTorqueDto(Guid id) : base(id)
    {
    }
}
