using System.Linq;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Roles.Entities;

namespace AgencyPro.Roles.Extensions
{
    public static partial class ContractorExtensions
    {
        public static IQueryable<Contractor> ForAgencyOwner(this IQueryable<Contractor> entities,
            IAgencyOwner ao)
        {
            return entities.Where(x => x.RecruiterOrganizationId == ao.OrganizationId);
        }

        public static IQueryable<Contractor> ForOrganizationRecruiter(this IQueryable<Contractor> entities,
            IOrganizationRecruiter re)
        {
            return entities.Where(x => x.RecruiterOrganizationId == re.OrganizationId && x.RecruiterId == re.RecruiterId);
        }
    }
}