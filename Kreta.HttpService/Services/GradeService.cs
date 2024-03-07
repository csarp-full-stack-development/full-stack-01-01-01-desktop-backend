using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.HttpService.Services
{
    public class GradeService : BaseService<Grade, GradeDto>, IGradeService
    {
        public GradeService(IHttpClientFactory? httpClientFactory, Assambler<Grade, GradeDto> assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
