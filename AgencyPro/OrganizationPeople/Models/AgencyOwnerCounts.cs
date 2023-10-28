namespace AgencyPro.OrganizationPeople.Models
{
    public class AgencyOwnerCounts
    {
        public int Accounts { get; set; }
        public int Projects { get; set; }

        public int ProviderContracts { get; set; }
        public int MarketingContracts { get; set; }
        public int RecruitingContracts { get; set; }

        public int Contracts => ProviderContracts + MarketingContracts + RecruitingContracts;
        public int People { get; set; }
        public int Invoices { get; set; }
        public int Leads { get; set; }
        public int Candidates { get; set; }
        public int Paychecks { get; set; }
        public int WorkOrders { get; set; }
        public int Proposals { get; set; }
        public int Stories { get; set; }
        public int TimeEntries { get; set; }

        public int ProviderMarketingPartner { get; set; }
        public int ProviderRecruitingPartner { get; set; }
        public int MarketingPartner { get; set; }
        public int RecruitingPartner { get; set; }
        public int ChannelPartners => ProviderMarketingPartner + ProviderRecruitingPartner + MarketingPartner + RecruitingPartner;

        public int Totals => TimeEntries 
                             + Stories 
                             + Proposals 
                             + Paychecks 
                             + Accounts 
                             + Leads 
                             + Projects 
                             + Contracts 
                             + WorkOrders 
                             + People 
                             + Invoices 
                             + Candidates
                             + ChannelPartners;

    }
}