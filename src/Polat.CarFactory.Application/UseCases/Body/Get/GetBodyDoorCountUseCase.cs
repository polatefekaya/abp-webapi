using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Body;

namespace Polat.CarFactory.UseCases.Body.Get;

public class GetBodyDoorCountUseCase : IUseCase<GetBodyDoorCountDto, int>
{
    public Task<int> ExecuteAsync(GetBodyDoorCountDto dto)
    {
        throw new NotImplementedException();
    }
}
