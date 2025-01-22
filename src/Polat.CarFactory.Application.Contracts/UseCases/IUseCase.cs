using System;
using System.Threading.Tasks;

namespace Polat.CarFactory.UseCases;

public interface IUseCase<TRequest>
{
    public Task ExecuteAsync(TRequest dto);
}
