using System;
using AgencyPro.Common.Metadata;
using Newtonsoft.Json;

namespace AgencyPro.TimeEntries.Models
{
    [FlowDirective(FlowRoleToken.Customer, "time")]
    public class CustomerTimeEntryOutput : TimeEntryOutput
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
        public override decimal InstantContractorStream { get; set; }
        [JsonIgnore]
        public override decimal TotalContractorStream { get; set; }

        [JsonIgnore]
        public override decimal InstantMarketerStream { get; set; }
        [JsonIgnore]
        public override decimal TotalMarketerStream { get; set; }

        [JsonIgnore]
        public override decimal InstantProjectManagerStream { get; set; }
        [JsonIgnore]
        public override decimal TotalProjectManagerStream { get; set; }

        [JsonIgnore]
        public override decimal InstantRecruiterStream { get; set; }
        [JsonIgnore]
        public override decimal TotalRecruiterStream { get; set; }

        [JsonIgnore]
        public override decimal InstantAccountManagerStream { get; set; }

        [JsonIgnore]
        public override decimal TotalAccountManagerStream { get; set; }
        
        public override decimal TotalCustomerAmount { get; set; }
        public override Guid TargetOrganizationId => this.CustomerOrganizationId;
        public override Guid TargetPersonId => this.CustomerId;
     
    }
}