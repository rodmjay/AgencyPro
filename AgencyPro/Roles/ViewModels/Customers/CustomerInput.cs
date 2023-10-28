using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AgencyPro.Roles.ViewModels.Customers
{
    public class CustomerInput : CustomerUpdateInput
    {
        [BindRequired] public virtual Guid PersonId { get; set; }

        [BindRequired] public virtual Guid MarketerId { get; set; }

        [BindRequired] public virtual Guid MarketerOrganizationId { get; set; }
    }
}