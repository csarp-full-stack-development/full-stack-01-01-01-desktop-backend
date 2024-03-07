using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.HttpService.Services
{
    public class PublicSpaceService : BaseService<PublicSpace, PublicScpaceDto>, IPublicSpaceService
    {
        public PublicSpaceService(IHttpClientFactory? httpClientFactory, Assambler<PublicSpace, PublicScpaceDto> assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
