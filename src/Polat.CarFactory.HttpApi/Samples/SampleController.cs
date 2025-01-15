using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Polat.CarFactory.DTOs;
using Polat.CarFactory.UseCases;
using Volo.Abp;

namespace Polat.CarFactory.Samples;

[Area(CarFactoryRemoteServiceConsts.ModuleName)]
[RemoteService(Name = CarFactoryRemoteServiceConsts.RemoteServiceName)]
[Route("api/CarFactory/sample")]
public class SampleController : CarFactoryController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;
    private readonly ICarCreateUseCase _carCreateUseCase;

    public SampleController(ISampleAppService sampleAppService, ICarCreateUseCase carCreateUseCase)
    {
        _sampleAppService = sampleAppService;
        _carCreateUseCase = carCreateUseCase;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpPost]
    [Authorize]
    public async Task<ActionResult<CarCreateResponseDto>> CreateCar(CarCreateRequestDto carCreateRequestDto){
        CarCreateDto carCreateDto = new (carCreateRequestDto.Price, carCreateRequestDto.Body, carCreateRequestDto.Tank);

        Guid id = await _carCreateUseCase.ExecuteAsync(carCreateDto);
        
        return Ok(new CarCreateResponseDto(id));
    }
}
