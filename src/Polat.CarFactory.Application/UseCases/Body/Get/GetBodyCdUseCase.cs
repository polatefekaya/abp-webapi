using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Body;

namespace Polat.CarFactory.UseCases.Body.Get;

public class GetBodyCdUseCase : IUseCase<GetBodyCdDto, decimal>
{
    public Task<decimal> ExecuteAsync(GetBodyCdDto dto)
    {
        throw new NotImplementedException();
    }
}
