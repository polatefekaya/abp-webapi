using System;
using System.Threading.Tasks;
using Polat.CarFactory.ValueObjects;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace Polat.CarFactory.AppServices.Generic;

public interface IGenericAppService : IPriceAppService, IWeightAppService, IVolumeAppService, IMaterialAppService, IApplicationService, IScopedDependency
{
}
