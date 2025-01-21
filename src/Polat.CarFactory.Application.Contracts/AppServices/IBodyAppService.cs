using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices.Generic;
using Polat.CarFactory.Enums;
using Polat.CarFactory.ValueObjects;

namespace Polat.CarFactory.AppServices;

public interface IBodyAppService : IGenericAppService, IMaterialAppService, IVolumeAppService
{
    public Task SetCd(Guid bodyId, decimal cd);
    public Task SetBodyType(Guid bodyId, BodyEnum body);
    public Task SetDoorCount(Guid bodyId, int count);
}
