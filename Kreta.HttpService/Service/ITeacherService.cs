using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Responses;

namespace Kreta.HttpService.Service
{
    public interface ITeacherService
    {
        public Task<List<Teacher>> SelectAllTeacher();
        public Task<ControllerResponse> UpdateAsync(Teacher teacherdto);
        public Task<ControllerResponse> DeleteAsync(Guid id);
        public Task<ControllerResponse> InsertAsync(Teacher teacher);
    

}
}
