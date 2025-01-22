using System;

namespace Polat.CarFactory.DTOs.UseCases.Base;

public record class BaseGuidDto
{
    public Guid Id {get;}

    public BaseGuidDto(Guid id){
        Id = id;
    }
}
