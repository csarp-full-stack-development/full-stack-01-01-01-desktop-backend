using Kreta.Backend.Context;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class SchoolClass<TDbContext> : RepositoryBase<TDbContext, SchoolClass>, ISchoolClass
        where TDbContext : DbContext
    {
        public SchoolClass(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
}
