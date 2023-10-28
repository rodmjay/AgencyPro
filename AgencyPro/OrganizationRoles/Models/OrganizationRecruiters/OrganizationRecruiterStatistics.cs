namespace AgencyPro.OrganizationRoles.Models.OrganizationRecruiters
{
    public class OrganizationRecruiterStatistics : OrganizationRecruiterOutput
    {
        public virtual int TotalContracts { get; set; }
        public virtual int TotalContractors { get; set; }
        public virtual int TotalCandidates { get; set; }
    }


}