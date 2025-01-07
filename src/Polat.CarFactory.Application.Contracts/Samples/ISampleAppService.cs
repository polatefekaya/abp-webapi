using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Polat.CarFactory.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
