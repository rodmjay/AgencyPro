using System;

namespace AgencyPro.Roles.Interfaces
{
    public interface IProjectManager
    {
        Guid Id { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}