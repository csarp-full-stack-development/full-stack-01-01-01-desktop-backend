
namespace Kreta.Shared.Models
{
    public class SchoolClass : IDbEntity<SchoolClass>
    {
        public Guid Id { get; set; }

        public bool HasId => Id!=Guid.Empty;
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClassType { get; set; }
    }
}
