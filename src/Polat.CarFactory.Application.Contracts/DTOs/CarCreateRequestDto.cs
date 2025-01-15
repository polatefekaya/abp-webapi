using Polat.CarFactory.Cars;
using Polat.CarFactory.ValueObjects;

namespace Polat.CarFactory.DTOs;

public record class CarCreateRequestDto
{
    public Money Price;
    public CarBody Body;
    public CarTank Tank;

    public CarCreateRequestDto(Money price, CarBody body, CarTank tank){
        Price = price;
        Body = body;
        Tank = tank;
    }
}
