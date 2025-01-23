using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Body.Get;

public record class GetBodyDoorCountDto : BaseGuidDto
{
    public GetBodyDoorCountDto(Guid id) : base(id)
    {
    }
}
