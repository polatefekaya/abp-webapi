using System;
using System.Threading.Tasks;
using Polat.CarFactory.ValueObjects;

namespace Polat.CarFactory.AppServices.Generic;

public interface IPriceAppService
{
    public Task SetPrice(Guid bodyId, Money price);
}
