using System;
using AgencyPro.Common.Metadata;
using Newtonsoft.Json;

namespace AgencyPro.TimeEntries.Models
{
    [FlowDirective(FlowRoleToken.Contractor, "time")]

    public class ContractorTimeEntryOutput : TimeEntryOutput
    {
        [JsonIgnore]
        public override decimal InstantAgencyStream { get; set; }
        [JsonIgnore]
        public override decimal TotalAgencyStream { get; set; }

        [JsonIgnore]
        public override decimal InstantSystemStream { get; set; }
        [JsonIgnore]
        public override decimal TotalSystemStream { get; set; }

        [JsonIgnore]
        public override decimal InstantRecruiterStream { get; set; }
        [JsonIgnore]
        public override decimal TotalRecruiterStream { get; set; }

        [JsonIgnore]
        public override decimal InstantMarketerStream { get; set; }
        [JsonIgnore]
        public override decimal TotalMarketerStream { get; set; }

        [JsonIgnore]
        public override decimal InstantProjectManagerStream { get; set; }
        [JsonIgnore]
        public override decimal TotalProjectManagerStream { get; set; }

        [JsonIgnore]
        public override decimal InstantAccountManagerStream { get; set; }
        [JsonIgnore]
        public override decimal TotalAccountManagerStream { get; set; }

        [JsonIgnore]
        public override decimal TotalCustomerAmount { get; set; }
        
        [JsonIgnore]
        public override decimal InstantMarketingAgencyStream { get; set; }

        public override Guid TargetOrganizationId => this.ContractorOrganizationId;
        public override Guid TargetPersonId => this.ContractorId;

        [JsonIgnore]
        public override decimal InstantRecruitingAgencyStream { get; set; }
        [JsonIgnore]
        public override decimal TotalMarketingAgencyStream { get; set; }
        [JsonIgnore]
        public override decimal TotalRecruitingAgencyStream { get; set; }
        [JsonIgnore]
        public override decimal TotalRecruitingStream { get; set; }
        [JsonIgnore]
        public override decimal TotalMarketingStream { get; set; }
        
    }
}