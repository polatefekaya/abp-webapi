using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Body.Get;

namespace Polat.CarFactory.UseCases.Body.Get;

public class GetBodyCdUseCase : IUseCase<GetBodyCdDto, string>
{
    public Task<string> ExecuteAsync(GetBodyCdDto dto)
    {
        throw new NotImplementedException();
    }
}
