namespace AgencyPro.OrganizationPeople.Models
{
    public class ContractorCounts
    {
        public int Contracts { get; set; }
        public int Stories { get; set; }
        public int TimeEntries { get; set; }
        public int Totals => Stories + Contracts + TimeEntries;
    }
}