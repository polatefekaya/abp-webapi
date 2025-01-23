using System;
using System.Threading.Tasks;
using Polat.CarFactory.DTOs.UseCases.Part.Get;
using Polat.CarFactory.DTOs.UseCases.Part.Response.Get;

namespace Polat.CarFactory.UseCases.Part.Get;

public class GetPartCategoryUseCase : IUseCase<GetPartCategoryDto, GetPartCategoryResponseDto>
{
    public Task<GetPartCategoryResponseDto> ExecuteAsync(GetPartCategoryDto dto)
    {
        throw new NotImplementedException();
    }
}
