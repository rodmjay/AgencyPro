using System;
using System.ComponentModel;

namespace AgencyPro.Organizations.Enums
{
    [Flags]
    public enum OrganizationType : int
    {
        [Description("Buyer")]
        Buyer = 0,

        [Description("Marketing")]
        Marketing = 1,

        [Description("Recruiting")]
        Recruiting = 2,

        [Description("Provider")]
        Provider = 4,

        [Description("Staffing")]
        StaffingAgency = Marketing | Recruiting,

        [Description("Full-Service")]
        FullServiceAgency = StaffingAgency | Provider
    }

}