using System;
using Newtonsoft.Json;

namespace AgencyPro.CustomerAccounts.Models
{
    public class AccountManagerCustomerAccountOutput : CustomerAccountOutput
    {
        [JsonIgnore] public override string AccountManagerImageUrl { get; set; }

        [JsonIgnore] public override string AccountManagerName { get; set; }
        [JsonIgnore] public override string AccountManagerEmail { get; set; }
        [JsonIgnore] public override string AccountManagerPhoneNumber { get; set; }

        [JsonIgnore] public override Guid AccountManagerId { get; set; }

        [JsonIgnore] public override Guid AccountManagerOrganizationId { get; set; }

        [JsonIgnore] public override string AccountManagerOrganizationName { get; set; }

        [JsonIgnore] public override string AccountManagerOrganizationImageUrl { get; set; }

        [JsonIgnore]
        public override int BuyerNumber { get; set; }

        [JsonIgnore] public override decimal MarketerStream { get; set; }
        [JsonIgnore] public override decimal MarketingAgencyStream { get; set; }
    }
}