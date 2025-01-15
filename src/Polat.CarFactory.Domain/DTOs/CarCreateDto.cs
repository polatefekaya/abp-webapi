using Polat.CarFactory.Cars;
using Polat.CarFactory.ValueObjects;

namespace Polat.CarFactory.DTOs;

public record class CarCreateDto
{
    public Money Price;
    public CarBody Body;
    public CarTank Tank;

    public CarCreateDto(Money price, CarBody body, CarTank tank){
        Price = price;
        Body = body;
        Tank = tank;
    }
}
