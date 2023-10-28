using System;
using Newtonsoft.Json;

namespace AgencyPro.Orders.Models
{
    public class ProviderWorkOrderOutput : WorkOrderOutput
    {
        [JsonIgnore]
        public override int BuyerNumber { get; set; }

        [JsonProperty("number")]
        public override int ProviderNumber { get; set; }

        public override Guid TargetOrganizationId => this.AccountManagerOrganizationId;


        public override Guid TargetPersonId => this.AccountManagerId;
    }
}