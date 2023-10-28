using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AgencyPro.RecruitingOrganizations.Models
{
    public class RecruitingOrganizationInput : RecruitingOrganizationUpgradeInput
    {
        [BindRequired] public virtual Guid DefaultRecruiterId { get; set; }
        


    }
}