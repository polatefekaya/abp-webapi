using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Body;

namespace Polat.CarFactory.UseCases.Body.Get;

public class GetBodyTypeUseCase : IUseCase<GetBodyTypeDto, string>
{
    public Task<string> ExecuteAsync(GetBodyTypeDto dto)
    {
        throw new NotImplementedException();
    }
}
