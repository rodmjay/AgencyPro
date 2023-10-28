namespace AgencyPro.OrganizationPeople.Models
{
    public class ProjectManagerCounts
    {
        public int Projects { get; set; }
        public int Proposals { get; set; }
        public int Contracts { get; set; }
        public int Stories { get; set; }
        public int Candidates { get; set; }
        public int TimeEntries { get; set; }

        public int Totals => Proposals + Projects + Contracts + Stories + Candidates + TimeEntries;
    }
}