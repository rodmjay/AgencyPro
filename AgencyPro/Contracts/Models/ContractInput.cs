using System;
using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Contracts.Models
{
    public class ContractInput
    {
        public virtual Guid ProjectId { get; set; }
        public virtual Guid ContractorId { get; set; }
        public virtual Guid ContractorOrganizationId { get; set; }

        [Range(1,60)]
        public virtual int MaxWeeklyHours { get; set; }

    }
}