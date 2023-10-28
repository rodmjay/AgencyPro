namespace AgencyPro.ProviderOrganizations.Models
{
    /// <summary>
    /// Organization from a provider agency owner's perspective
    /// </summary>
    public class AgencyOwnerProviderOrganizationDetailsOutput : ProviderOrganizationDetailsOutput
    {
       // public ICollection<AgencyOwnerOrganizationPersonOutput> OrganizationPeople { get; set; }
       // public ICollection<OrganizationSkillOutput> Skills { get; set; }
        // public ICollection<AgencyOwnerCustomerAccountOutput> CustomerAccounts { get; set; }
        //public ICollection<AgencyOwnerProjectOutput> Projects { get; set; }
        //public ICollection<AgencyOwnerContractOutput> Contracts { get; set; }
        // public ICollection<AgencyOwnerCandidateOutput> Candidates { get; set; }
        //public ICollection<AgencyOwnerLeadOutput> Leads { get; set; }


        public override int PreviousDaysAllowed { get; set; }
        public override decimal SystemStream { get; set; }
        public override string ContractorInformation { get; set; }
        public override int FutureDaysAllowed { get; set; }
        public override string ProviderInformation { get; set; }
        public override string ProjectManagerInformation { get; set; }
        public override string AccountManagerInformation { get; set; }
    }
}