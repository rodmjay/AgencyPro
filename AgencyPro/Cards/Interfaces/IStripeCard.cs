using System;

namespace AgencyPro.Cards.Interfaces
{
    public interface IStripeCard
    {
        string Id { get; set; }
        string AddressCity { get; set; }
        string AddressCountry { get; set; }
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string Brand { get; set; }
        string Country { get; set; }
        string CvcCheck { get; set; }
        string DynamicLast4 { get; set; }
        int ExpMonth { get; set; }
        int ExpYear { get; set; }
        string Funding { get; set; }
        string Last4 { get; set; }
        string Name { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}