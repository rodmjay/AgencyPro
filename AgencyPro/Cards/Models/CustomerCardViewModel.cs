using System;
using AgencyPro.Cards.Interfaces;
using Newtonsoft.Json;

namespace AgencyPro.Cards.Models
{
    public class CustomerCardViewModel : IStripeCard
    {
        public string Id { get; set; }
        public string AddressCity { get; set; }
        public string AddressCountry { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Brand { get; set; }
        public string Country { get; set; }
        public string CvcCheck { get; set; }
        public string DynamicLast4 { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string Funding { get; set; }
        public string Last4 { get; set; }

        [JsonIgnore()]
        public string Name { get; set; }

        [JsonProperty("name")]
        public string NameInternal => $@"{Brand}-{Last4}";

        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }

    }
}