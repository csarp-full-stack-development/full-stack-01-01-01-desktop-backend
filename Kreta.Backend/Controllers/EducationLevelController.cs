using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EducationLevelController : BaseController<EducationLevel, EducationLevelDto>
    {
        public EducationLevelController(EducationLevelAssambler assembler, IEducationLevelRepo repo) : base(assembler, repo)
        {
        }
    }
}
