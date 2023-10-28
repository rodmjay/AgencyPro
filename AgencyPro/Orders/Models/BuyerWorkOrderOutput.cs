using System;
using Newtonsoft.Json;

namespace AgencyPro.Orders.Models
{
    public class BuyerWorkOrderOutput : WorkOrderOutput
    {
        [JsonProperty("number")]
        public override int BuyerNumber { get; set; }

        [JsonIgnore]
        public override int ProviderNumber { get; set; }

        public override Guid TargetOrganizationId => this.CustomerOrganizationId;
        public override Guid TargetPersonId => this.CustomerId;
    }
}