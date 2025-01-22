using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Part;

namespace Polat.CarFactory.AppServices;

public interface IPartAppService : IGenericAppService
{
    public Task SetAxle(SetPartAxleDto dto);
    public Task SetCategory(SetPartCategoryDto dto);
}
