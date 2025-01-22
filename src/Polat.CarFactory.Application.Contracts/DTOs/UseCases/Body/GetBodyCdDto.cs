using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Body;

public record class GetBodyCdDto : BaseGuidDto
{
    public GetBodyCdDto(Guid id) : base(id)
    {
    }
}
