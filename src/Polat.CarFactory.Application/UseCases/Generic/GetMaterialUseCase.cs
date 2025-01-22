using System;
using System.Threading.Tasks;

namespace Polat.CarFactory.UseCases.Generic;

public class GetMaterialUseCase : IUseCase<Guid, string>
{
    public Task<string> ExecuteAsync(Guid dto)
    {
        throw new NotImplementedException();
    }
}
