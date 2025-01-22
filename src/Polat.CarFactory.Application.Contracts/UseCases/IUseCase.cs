using System;
using System.Threading.Tasks;

namespace Polat.CarFactory.UseCases;

public interface IUseCase<TRequest>
{
    public Task ExecuteAsync(TRequest dto);
}

public interface IUseCase<TRequest, TReturn>
{
    public Task<TReturn> ExecuteAsync(TRequest dto);
}
