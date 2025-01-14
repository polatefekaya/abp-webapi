using System;
using Polat.CarFactory.Entities;
using Volo.Abp.Domain.Entities;

namespace Polat.CarFactory.Cars;

public class CarBody : Entity<Guid>
{
    public Guid CarId {get; private set;}
    public Guid BodyId {get; private set;}

    public Body Body {get; private set;} = null!;
    
    protected CarBody(){}

    public CarBody(Guid id, Guid carId, Guid bodyId) : base(id){
        CarId = carId;
        BodyId = bodyId;
    }
}
