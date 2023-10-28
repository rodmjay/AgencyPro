using System;

namespace AgencyPro.ProviderOrganizations.Interfaces
{
    public interface IProviderOrganization
    {
        decimal AccountManagerStream { get; set; }
        decimal ProjectManagerStream { get; set; }
        decimal AgencyStream { get; set; }
        decimal ContractorStream { get; set; }
        string ProviderInformation { get; set; }
        string ProjectManagerInformation { get; set; }
        string AccountManagerInformation { get; set; }
        string ContractorInformation { get; set; }
        int EstimationBasis { get; set; }
        int FutureDaysAllowed { get; set; }
        int PreviousDaysAllowed { get; set; }
        decimal SystemStream { get; set; }
        Guid DefaultAccountManagerId { get; set; }
        Guid DefaultProjectManagerId { get; set; }
        Guid DefaultContractorId { get; set; }
        Guid Id { get; set; }
    }
}