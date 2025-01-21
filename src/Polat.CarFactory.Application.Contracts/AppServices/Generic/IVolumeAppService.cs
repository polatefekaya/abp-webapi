using System;
using System.Threading.Tasks;

namespace Polat.CarFactory.AppServices.Generic;

public interface IVolumeAppService
{
    public Task SetVolume(Guid id, int volume);
}
