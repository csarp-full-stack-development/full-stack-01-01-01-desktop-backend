using Kreta.Shared.Models;

namespace Kreta.Shared.Dtos
{
    public class SchoolClassDto
    {
        public Guid Id { get; set; }
        public bool HasId => Id != Guid.Empty;
        public int SchoolYear { get; set; } = -1;
        public SchoolClassType SchoolClassType { get; set; }
        public Guid? TypeOfEducationId { get; set; }
        public Guid? EducationLevelId { get; set; }
        public int YearOfEnrolment { get; set; }
        public bool IsArchived { get; set; } = false;
    }
}
