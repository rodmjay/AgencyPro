namespace AgencyPro.OrganizationPeople.Models
{
    public class CustomerCounts
    {
        public int Accounts { get; set; }
        public int Projects { get; set; }
        public int Contracts { get; set; }
        public int WorkOrders { get; set; }
        public int Proposals { get; set; }
        public int Invoices { get; set; }
        public int FinancialAccounts { get; set; }

        public int Totals => Proposals + Invoices + FinancialAccounts + Accounts + WorkOrders + Projects + Contracts;

    }
}