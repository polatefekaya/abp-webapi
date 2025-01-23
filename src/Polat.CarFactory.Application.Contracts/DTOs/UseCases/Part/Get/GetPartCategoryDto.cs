using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Part.Get;

public record class GetPartCategoryDto : BaseGuidDto
{
    public GetPartCategoryDto(Guid id) : base(id)
    {
    }
}
