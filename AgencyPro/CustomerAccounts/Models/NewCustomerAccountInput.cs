using System;
using System.ComponentModel.DataAnnotations;
using AgencyPro.People.Models;

namespace AgencyPro.CustomerAccounts.Models
{
    public class NewCustomerAccountInput : PersonInput
    {
        public Guid? MarketerId { get; set; }

        public Guid? AccountManagerId { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public string OrganizationName { get; set; }

        public int? PaymentTermId { get; set; }
        public Guid? MarketerOrganizationId { get; set; }
        public bool AutoApproveTimeEntries { get; set; }
        
    }
}