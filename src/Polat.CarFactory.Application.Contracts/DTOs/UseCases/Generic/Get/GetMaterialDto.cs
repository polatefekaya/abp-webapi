using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Generic.Get;

public record class GetMaterialDto : BaseGuidDto
{
    public GetMaterialDto(Guid id) : base(id)
    {
    }
}
