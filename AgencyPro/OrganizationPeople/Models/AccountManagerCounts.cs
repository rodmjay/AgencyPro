namespace AgencyPro.OrganizationPeople.Models
{
    public class AccountManagerCounts
    {
        public int Accounts { get; set; }
        public int Leads { get; set; }
        public int Projects { get; set; }
        public int Contracts { get; set; }
        public int WorkOrders { get; set; }
        public int People { get; set; }
        public int Stories { get; set; }

        public int Totals => Proposals + Invoices + Stories + People + Accounts + Leads + Projects + Contracts + WorkOrders;

        public int Invoices { get; set; }
        public int Proposals { get; set; }
    }
}