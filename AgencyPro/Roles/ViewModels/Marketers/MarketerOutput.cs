using System;
using AgencyPro.Roles.Interfaces;

namespace AgencyPro.Roles.ViewModels.Marketers
{
    public class MarketerOutput : MarketerInput, IMarketer
    {
        public Guid Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
    }
}