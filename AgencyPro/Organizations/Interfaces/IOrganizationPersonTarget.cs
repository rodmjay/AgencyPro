using System;

namespace AgencyPro.Organizations.Interfaces
{
    public interface IOrganizationPersonTarget
    {
        Guid TargetOrganizationId { get; }
        Guid TargetPersonId { get;  }
    }
}