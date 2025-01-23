using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Generic.Response.Get;

namespace Polat.CarFactory.UseCases.Generic.Get;

public class GetMaterialUseCase : IUseCase<Guid, GetMaterialResponseDto>
{
    public Task<GetMaterialResponseDto> ExecuteAsync(Guid dto)
    {
        throw new NotImplementedException();
    }
}
