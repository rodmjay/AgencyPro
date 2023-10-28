using System;
using Newtonsoft.Json;

namespace AgencyPro.CustomerAccounts.Models
{
    public class CustomerCustomerAccountOutput : CustomerAccountOutput
    {
        [JsonProperty("number")]
        public override int BuyerNumber { get; set; }

        [JsonIgnore]
        public override int Number { get; set; }

        [JsonIgnore] public override string CustomerImageUrl { get; set; }

        [JsonIgnore] public override string CustomerName { get; set; }
        [JsonIgnore] public override string CustomerEmail { get; set; }
        [JsonIgnore] public override string CustomerPhoneNumber { get; set; }

        [JsonIgnore] public override Guid CustomerId { get; set; }

        [JsonIgnore] public override Guid CustomerOrganizationId { get; set; }

        [JsonIgnore] public override string CustomerOrganizationName { get; set; }

        [JsonIgnore] public override string CustomerOrganizationImageUrl { get; set; }

        [JsonIgnore] public override decimal MarketerStream { get; set; }
        [JsonIgnore] public override decimal MarketingAgencyStream { get; set; }
    }
}