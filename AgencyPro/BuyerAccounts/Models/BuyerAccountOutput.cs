using System;
using AgencyPro.BuyerAccounts.Interfaces;
using Newtonsoft.Json;

namespace AgencyPro.BuyerAccounts.Models
{
    public class BuyerAccountOutput : IBuyerAccount
    {
        public decimal Balance { get; set; }
        public bool Delinquent { get; set; }

        [JsonIgnore]
        public string Id { get; set; }

        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
    }
}
