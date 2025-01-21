using System;
using System.Threading.Tasks;
using Polat.CarFactory.AppServices;
using Polat.CarFactory.Enums;
using Polat.CarFactory.UseCases.Body;
using Polat.CarFactory.ValueObjects;

namespace Polat.CarFactory.Controllers.v1;

public class BodyController : CarFactoryController, IBodyAppService
{
    private readonly IBodySetCdUseCase _setCdUseCase;
    public BodyController(IBodySetCdUseCase setCdUseCase){
        _setCdUseCase = setCdUseCase;
    }
    public Task SetBodyType(Guid bodyId, BodyEnum body)
    {
        throw new NotImplementedException();
    }

    public async Task SetCd(Guid bodyId, decimal cd)
    {
        await _setCdUseCase.Execute(bodyId, cd);
    }

    public Task SetDoorCount(Guid bodyId, int count)
    {
        throw new NotImplementedException();
    }

    public Task SetMaterial(Guid bodyId, MaterialEnum material)
    {
        throw new NotImplementedException();
    }

    public Task SetPrice(Guid bodyId, Money price)
    {
        throw new NotImplementedException();
    }

    public Task SetVolume(Guid bodyId, int volume)
    {
        throw new NotImplementedException();
    }

    public Task SetWeight(Guid bodyId, int weight)
    {
        throw new NotImplementedException();
    }
}
