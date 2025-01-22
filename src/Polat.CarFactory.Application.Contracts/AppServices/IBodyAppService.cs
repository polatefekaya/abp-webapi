using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.DTOs.UseCases.Body;
using Polat.CarFactory.Enums;
using Polat.CarFactory.ValueObjects;

namespace Polat.CarFactory.AppServices;

public interface IBodyAppService : IGenericAppService, IMaterialAppService, IVolumeAppService
{
    public Task SetCd(SetBodyCdDto dto);
    public Task SetBodyType(SetBodyTypeDto dto);
    public Task SetDoorCount(SetBodyDoorCountDto dto);
    public Task<decimal> GetCd(GetBodyCdDto dto);
}
