using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Uow;

namespace Polat.CarFactory.UseCases;

public interface IUseCase<TRequest> : IScopedDependency, IUnitOfWorkEnabled
{
    public Task ExecuteAsync(TRequest dto);
}

public interface IUseCase<TRequest, TReturn> : IScopedDependency
{
    public Task<TReturn> ExecuteAsync(TRequest dto);
}
