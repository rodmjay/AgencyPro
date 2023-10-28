namespace AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers
{
    public class OrganizationAccountManagerStatistics : OrganizationAccountManagerOutput
    {
        public virtual int TotalAccounts { get; set; }
        public virtual int TotalProjects { get; set; }
        public virtual int TotalContracts { get; set; }
        public virtual int TotalLeads { get; set; }
        public virtual int MaxWeeklyHours { get; set; }
    }
}