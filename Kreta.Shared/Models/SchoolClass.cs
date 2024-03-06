
namespace Kreta.Shared.Models
{
    public class SchoolClass : IDbEntity<SchoolClass>
    {
        public SchoolClass()
        {
            Id = Guid.Empty;
            SchoolYear = -1;
            SchoolClassType = SchoolClassType.ClassA;
            TypeOfEducationId = Guid.Empty;
            EducationLevelId = Guid.Empty;
            YearOfEnrolment = -1;
            IsArchived = false;
            HeadTeacherId = Guid.Empty;
        }

        public SchoolClass(Guid id, int schoolYear, SchoolClassType schoolClassType, int yearOfEnrolment, bool isArchived, Guid typeOfEducationId, Guid educationLevelId,  Guid headTeacherId)
        {
            Id = id;
            SchoolYear = schoolYear;
            SchoolClassType = schoolClassType;
            TypeOfEducationId = typeOfEducationId;
            EducationLevelId = educationLevelId;
            YearOfEnrolment = yearOfEnrolment;
            IsArchived = isArchived;
            HeadTeacherId = headTeacherId;
        }

        public Guid Id { get; set; }
        public bool HasId => Id != Guid.Empty;
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClassType { get; set; }
        public Guid? TypeOfEducationId { get; set; }
        public Guid? EducationLevelId { get; set; }
        public Guid? HeadTeacherId { get; set; }
        public int YearOfEnrolment {  get; set; }
        public bool IsArchived { get; set; }
    }
}
