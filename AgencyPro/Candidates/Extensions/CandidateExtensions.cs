using System.Linq;
using AgencyPro.Candidates.Entities;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.Candidates.Extensions
{
    public static partial class CandidateExtensions
    {
        public static IQueryable<Candidate> ForOrganizationProjectManager(this IQueryable<Candidate> entities,
            IOrganizationProjectManager pm)
        {
            return entities.Where(x =>
                x.ProjectManagerId == pm.ProjectManagerId && x.ProjectManagerOrganizationId == pm.OrganizationId);
        }

        public static IQueryable<Candidate> ForOrganizationRecruiter(this IQueryable<Candidate> entities,
            IOrganizationRecruiter re)
        {
            return entities.Where(
                x => x.RecruiterId == re.RecruiterId && x.RecruiterOrganizationId == re.OrganizationId);
        }

        public static IQueryable<Candidate> ForAgencyOwner(this IQueryable<Candidate> entities, IProviderAgencyOwner ao)
        {
            return entities.Where(x => x.ProviderOrganizationId == ao.OrganizationId);
        }
    }
}