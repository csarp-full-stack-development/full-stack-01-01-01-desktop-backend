using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Assamblers
{
    public class AddressAssambler : Assambler<Address, PublicScpaceDto>
    {
        public override PublicScpaceDto ToDto(Address domainEntity)
        {
            throw new NotImplementedException();
        }

        public override Address ToModel(PublicScpaceDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
