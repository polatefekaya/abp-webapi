using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Body.Get;

public record class GetBodyTypeDto : BaseGuidDto
{
    public GetBodyTypeDto(Guid id) : base(id)
    {
    }
}
