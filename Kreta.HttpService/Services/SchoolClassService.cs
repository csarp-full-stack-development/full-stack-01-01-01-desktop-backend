using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.HttpService.Services
{
    public class SchoolClassService : BaseService<SchoolClass, SchoolClassDto>, ISchoolClassService
    {
        public SchoolClassService(IHttpClientFactory? httpClientFactory, Assambler<SchoolClass, SchoolClassDto> assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
