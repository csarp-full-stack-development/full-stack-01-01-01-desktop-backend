using Kreta.Backend.Controllers.Assamblers;
using Kreta.Backend.Repos;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Backend.Controllers
{
    public class EducationLevelController : BaseController<EducationLevel, EducationLevelDto>
    {
        public EducationLevelController(EducationLevelAssambler assembler, IEducationLevelRepo repo) : base(assembler, repo)
        {
        }
    }
}
