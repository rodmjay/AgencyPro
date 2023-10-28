using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AgencyPro.People.Models
{
    public class SwitchOrganizationInput
    {
        [BindNever] public Guid PersonId { get; set; }

        [BindRequired] public Guid OrganizationId { get; set; }
    }
}