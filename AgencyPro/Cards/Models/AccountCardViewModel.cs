using System;
using AgencyPro.Cards.Interfaces;

namespace AgencyPro.Cards.Models
{
    public class AccountCardViewModel : IStripeCard
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
        public string Name { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }

        public string Status { get; set; }
        public string Type { get; set; }

    }
}
