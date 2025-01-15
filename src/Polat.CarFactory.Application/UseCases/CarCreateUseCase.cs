using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs;

namespace Polat.CarFactory.UseCases;

public class CarCreateUseCase : ICarCreateUseCase
{
    public Task<Guid> ExecuteAsync(CarCreateDto carCreateDto)
    {
        throw new NotImplementedException();
    }
}
