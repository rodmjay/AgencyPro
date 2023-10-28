namespace AgencyPro.OrganizationPeople.Models
{
    public class RecruiterCounts
    {
        public int Contractors { get; set; }
        public int Candidates { get; set; }
        public int Contracts { get; set; }
        public int ChannelPartners { get; set; }
        public int Totals => Contractors + Candidates + Contracts + ChannelPartners;

    }
}