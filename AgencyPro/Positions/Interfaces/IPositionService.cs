using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Positions.Models;

namespace AgencyPro.Positions.Interfaces
{
    public interface IPositionService
    {
        Task<PositionOutput> GetPosition(int positionId);
        Task<List<OrganizationPositionOutput>> GetPositions(Guid organizationId);
        Task<Result> Add(IAgencyOwner agencyOwner, int positionId);
        Task<Result> Remove(IAgencyOwner agencyOwner, int positionId);
    }
}
