using System;
using System.Threading.Tasks;

namespace Polat.CarFactory.UseCases.Body;

public interface IBodySetCdUseCase
{
    public Task Execute(Guid id, decimal cd);
}
