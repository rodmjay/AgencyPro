using System;
using AgencyPro.Common.Metadata;
using Newtonsoft.Json;

namespace AgencyPro.Projects.Models
{
    [FlowDirective(FlowRoleToken.Customer, "projects")]
    public class CustomerProjectOutput : ProjectOutput
    {
        [JsonIgnore] public override string CustomerName { get; set; }
        [JsonIgnore] public override string CustomerImageUrl { get; set; }
        [JsonIgnore] public override string CustomerEmail { get; set; }
        [JsonIgnore] public override string CustomerPhoneNumber { get; set; }
        [JsonIgnore] public override Guid CustomerId { get; set; }
        [JsonIgnore] public override Guid CustomerOrganizationId { get; set; }
        [JsonIgnore] public override string CustomerOrganizationImageUrl { get; set; }
        [JsonIgnore] public override string CustomerOrganizationName { get; set; }

        [JsonIgnore] public override decimal MaxMarketerStream { get; set; }
        [JsonIgnore] public override decimal MaxRecruiterStream { get; set; }
        [JsonIgnore] public override decimal MaxAccountManagerStream { get; set; }
        [JsonIgnore] public override decimal MaxAgencyStream { get; set; }
        [JsonIgnore] public override decimal MaxRecruitingAgencyStream { get; set; }
        [JsonIgnore] public override decimal MaxMarketingAgencyStream { get; set; }
        [JsonIgnore] public override decimal MaxContractorStream { get; set; }
        [JsonIgnore] public override decimal MaxProjectManagerStream { get; set; }
        [JsonIgnore] public override decimal MaxSystemStream { get; set; }

        [JsonIgnore] public override decimal WeightedAccountManagerAverage { get; }
        [JsonIgnore] public override decimal WeightedAgencyAverage { get; }
        [JsonIgnore] public override decimal WeightedMarketingAgencyAverage { get; }
        [JsonIgnore] public override decimal WeightedRecruitingAgencyAverage { get; }
        [JsonIgnore] public override decimal WeightedContractorAverage { get; }
        public override Guid TargetOrganizationId => this.CustomerOrganizationId;
        public override Guid TargetPersonId => this.CustomerId;

        [JsonIgnore] public override decimal WeightedMarketerAverage { get; }
        [JsonIgnore] public override decimal WeightedProjectManagerAverage { get; }
        [JsonIgnore] public override decimal WeightedRecruiterAverage { get; }
        [JsonIgnore] public override decimal WeightedSystemAverage { get; }
    }
}