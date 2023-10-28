using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.BonusIntents.Models;
using AgencyPro.Common.Models;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.BonusIntents.Interfaces
{
    public interface IOrganizationBonusIntentService
    {
        Task<List<OrganizationBonusIntentOutput>> GetBonusIntents(IAgencyOwner person);
        Task<Result> Create(CreateBonusIntentOptions createBonusIntentOptions);
    }
}