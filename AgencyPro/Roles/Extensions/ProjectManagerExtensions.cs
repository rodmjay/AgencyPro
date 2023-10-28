using System.Linq;
using AgencyPro.Roles.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgencyPro.Roles.Extensions
{
    public static class ProjectManagerExtensions
    {
        public static IQueryable<ProjectManager> IncludeStandardIncludes(this IQueryable<ProjectManager> entities)
        {
            return entities.Include(x => x.Person);
        }

        public static IQueryable<ProjectManager> IncludeDetailedIncludes(this IQueryable<ProjectManager> entities)
        {
            return entities.IncludeStandardIncludes()
                .Include(x => x.OrganizationProjectManagers);
        }
    }
}