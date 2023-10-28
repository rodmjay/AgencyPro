namespace AgencyPro.OrganizationPeople.Models
{
    public class MarketerCounts
    {
        public int Customers { get; set; }
        public int Leads { get; set; }
        public int Contracts { get; set; }
        public int ChannelPartners { get; set; }
        public int Totals => Customers + Leads + Contracts + ChannelPartners;

    }
}