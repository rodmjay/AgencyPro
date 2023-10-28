namespace AgencyPro.ProviderOrganizations.Models
{
    public class ProviderAgencyOwnerOrganizationOutput : ProviderOrganizationOutput
    {
        public virtual int MaxWeeklyHours { get; set; }
        public virtual int HoursLoggedThisWeek { get; set; }

        public int TotalContractors { get; set; }
        public int TotalMarketers { get; set; }
        public int TotalRecruiters { get; set; }
        public int TotalProjectManagers { get; set; }
        public int TotalAccountManagers { get; set; }
        public int TotalCustomers { get; set; }
        public int TotalProjects { get; set; }
        public int TotalContracts { get; set; }
        public int TotalAccounts { get; set; }
        public decimal DefaultContractorStream { get; set; }

        public override decimal SystemStream { get; set; }
        public override int PreviousDaysAllowed { get; set; }
        public override string ContractorInformation { get; set; }
        public override int FutureDaysAllowed { get; set; }
        public override string ProviderInformation { get; set; }
        public override string ProjectManagerInformation { get; set; }
        public override string AccountManagerInformation { get; set; }
    }
}