using System;
using AgencyPro.Roles.Interfaces;

namespace AgencyPro.Roles.ViewModels.Recruiters
{
    public class RecruiterOutput : RecruiterInput, IRecruiter
    {
        public Guid Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
    }
}