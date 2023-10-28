using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Roles.Interfaces;
using AgencyPro.Skills.Models;

namespace AgencyPro.Skills.Interfaces
{
    public interface IContractorSkillService
    {
        Task<ContractorSkillOutput> Add(IContractor contractor, Guid skillId, ContractorSkillInput input);
        Task<ContractorSkillOutput> Update(IContractor contractor, Guid skillId, ContractorSkillInput input);

        Task<bool> Remove(IContractor contractor, Guid skillId);

        Task<List<ContractorSkillOutput>> GetSkills(IContractor contractor);
    }
}