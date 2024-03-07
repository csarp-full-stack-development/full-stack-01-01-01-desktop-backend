using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressRepo : BaseController<Address, PublicScpaceDto>
    {
        public AddressRepo(AddressAssambler assambler, IAddressRepo repo) : base(assambler, repo)
        {
        }
    }
}
