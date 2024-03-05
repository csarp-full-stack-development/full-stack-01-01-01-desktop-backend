using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class SchoolClassExtension
    {
        public static SchoolClass ToModel(this SchoolClassDto dto)
        {
            return new SchoolClass
            {
                Id = dto.Id,
                SchoolYear = dto.SchoolYear,
                SchoolClassType = dto.SchoolClassType,
                TypeOfEducationId = dto.TypeOfEducationId,
                EducationLevelId = dto.EducationLevelId,
                YearOfEnrolment= dto.YearOfEnrolment,
                IsArchived = dto.IsArchived,
            };
        }

        public static SchoolClassDto ToDto(this SchoolClass model)
        {
            return new SchoolClassDto
            {
                Id = model.Id,
                SchoolYear = model.SchoolYear,
                SchoolClassType = model.SchoolClassType,
                TypeOfEducationId = model.TypeOfEducationId,
                YearOfEnrolment = model.YearOfEnrolment,
                IsArchived = model.IsArchived,
            };
        }
    }
}
