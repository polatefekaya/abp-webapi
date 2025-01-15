using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs;

namespace Polat.CarFactory.UseCases;

public interface ICarCreateUseCase
{
    public Task<Guid> ExecuteAsync(CarCreateDto carCreateDto);
}
