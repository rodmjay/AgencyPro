using System;
using System.ComponentModel.DataAnnotations;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.OrganizationRoles.Models.OrganizationMarketers
{
    public class OrganizationMarketerInput : IOrganizationMarketer
    {
        [Required] public virtual decimal MarketerStream { get; set; }
        public virtual decimal MarketerBonus { get; set; }
        public virtual Guid MarketerId { get; set; }
        public virtual Guid OrganizationId { get; set; }
    }
}