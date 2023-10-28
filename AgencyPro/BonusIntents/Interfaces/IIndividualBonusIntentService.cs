using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.BonusIntents.Models;
using AgencyPro.Common.Models;
using AgencyPro.OrganizationPeople.Interfaces;

namespace AgencyPro.BonusIntents.Interfaces
{
    public interface IIndividualBonusIntentService
    {
        Task<List<IndividualBonusIntentOutput>> GetBonusIntents(IOrganizationPerson person);
        Task<Result> Create(CreateBonusIntentOptions options);
        Task<List<IndividualBonusIntentOutput>> GetPending(IOrganizationPerson person, BonusFilters filters);
    }
}
