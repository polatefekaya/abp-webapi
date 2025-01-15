using System;

namespace Polat.CarFactory.DTOs;

public record class CarCreateResponseDto
{
    public Guid CarId;
    public CarCreateResponseDto(Guid carId){
        CarId = carId;
    }
}
