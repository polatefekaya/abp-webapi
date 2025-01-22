using System;
using System.Threading.Tasks;
using Polat.CarFactory.ValueObjects;

namespace Polat.CarFactory.AppServices.Generic;

public interface IGenericAppService : IPriceAppService, IWeightAppService, IVolumeAppService, IMaterialAppService
{
}
