using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AgencyPro.CustomerAccounts.Models
{
    public class LinkCustomerInput
    {
        [BindRequired] public Guid AccountManagerId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public Guid AccountManagerOrganizationId { get; set; }

        public int? PaymentTermId { get; set; }
    }
}