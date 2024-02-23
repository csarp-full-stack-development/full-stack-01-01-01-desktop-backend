using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Responses;

namespace Kreta.HttpService.Service
{
    public interface IParentService
    {
        public Task<List<Parent>> SelectAllParent();
        public Task<ControllerResponse> UpdateAsync(Parent parentdto);
        public Task<ControllerResponse> DeleteAsync(Guid id);
        public Task<ControllerResponse> InsertAsync(Parent parent);

    }
}
