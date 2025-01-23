using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Generic.Get;

public record class GetVolumeDto : BaseGuidDto
{
    public GetVolumeDto(Guid id) : base(id)
    {
    }
}
