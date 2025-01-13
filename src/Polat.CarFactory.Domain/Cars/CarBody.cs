using System;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Cars;

public class CarBody : Entity<Guid>
{
    public Guid CarId {get; private set;}
    public Guid BodyId {get; private set;}
}
