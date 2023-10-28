using System;

namespace AgencyPro.Roles.Interfaces
{
    public interface IAccountManager
    {
        Guid Id { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}