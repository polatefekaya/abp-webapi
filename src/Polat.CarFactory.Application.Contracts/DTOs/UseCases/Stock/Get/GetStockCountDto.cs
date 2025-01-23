using System;
using Polat.CarFactory.DTOs.UseCases.Base;

namespace Polat.CarFactory.DTOs.UseCases.Stock.Get;

public record class GetStockCountDto : BaseGuidDto
{
    public GetStockCountDto(Guid id) : base(id)
    {
    }
}
