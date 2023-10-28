using System.ComponentModel;

namespace AgencyPro.Common.Metadata
{

    public enum FlowRoleToken
    {
        [Description("")]
        None,

        [Description("agency-owner")]
        AgencyOwner,

        [Description("account-manager")]
        AccountManager,

        [Description("project-manager")]
        ProjectManager,

        [Description("contractor")]
        Contractor,

        [Description("customer")]
        Customer,

        [Description("recruiter")]
        Recruiter,

        [Description("marketer")]
        Marketer,

        [Description("marketing-agency-owner")]
        MarketingAgencyOwner,

        [Description("recruiting-agency-owner")]
        RecruitingAgencyOwner,
    }
}