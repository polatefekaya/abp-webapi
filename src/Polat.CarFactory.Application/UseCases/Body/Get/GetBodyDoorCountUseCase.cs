using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Body.Get;

namespace Polat.CarFactory.UseCases.Body.Get;

public class GetBodyDoorCountUseCase : IUseCase<GetBodyDoorCountDto, string>
{
    public Task<string> ExecuteAsync(GetBodyDoorCountDto dto)
    {
        throw new NotImplementedException();
    }
}
