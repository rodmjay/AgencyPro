using System;
using Newtonsoft.Json;

namespace AgencyPro.Leads.Models
{
    public class MarketerLeadMatrixOutput : LeadMatrixOutput
    {
        [JsonIgnore]
        public override Guid MarketerId { get; set; }

        [JsonIgnore]
        public override Guid MarketerOrganizationId { get; set; }
    }
}