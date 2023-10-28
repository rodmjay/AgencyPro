using System;
using AgencyPro.Common.Models;

namespace AgencyPro.Agreements.Models
{
    public class AgreementResult : Result
    {
        public Guid? MarketingOrganizationId { get; set; }
        public Guid? ProviderOrganizationId { get; set; }
        public Guid? RecruitingOrganizationId { get; set; }
    }
}