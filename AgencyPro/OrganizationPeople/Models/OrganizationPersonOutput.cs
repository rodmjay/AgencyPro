using System;
using AgencyPro.OrganizationPeople.Interfaces;
using AgencyPro.Organizations.Interfaces;
using AgencyPro.People.Enums;
using Newtonsoft.Json;

namespace AgencyPro.OrganizationPeople.Models
{
    public class OrganizationPersonOutput : OrganizationPersonInput, IOrganizationPerson, IOrganizationPersonTarget
    {
        public virtual bool IsDefaultAccountManager { get; set; }
        public virtual bool IsDefaultProjectManager { get; set; }
        public virtual bool IsDefaultRecruiter { get; set; }
        public virtual bool IsDefaultMarketer { get; set; }

        public virtual string DisplayName { get; set; }
        public virtual string ImageUrl { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTimeOffset? LastLogin { get; set; }

        public bool HasFinancialAccount { get; set; }

        public virtual Guid OrganizationId { get; set; }
        public virtual string OrganizationName { get; set; }
        public virtual string OrganizationImageUrl { get; set; }

        public virtual PersonStatus Status { get; set; }

        [JsonIgnore] public virtual bool IsHidden { get; set; }

        [JsonIgnore] public virtual long PersonFlags { get; set; }

        [JsonIgnore] public virtual long AgencyFlags { get; set; }

        [JsonIgnore] public virtual bool IsOrganizationOwner { get; set; }
        [JsonIgnore] public virtual bool IsDefault { get; set; }
        public virtual DateTimeOffset Created { get; set; }
        public virtual DateTimeOffset Updated { get; set; }
        public virtual string AffiliateCode { get; set; }

        [JsonIgnore] public virtual Guid TargetOrganizationId => this.OrganizationId;
        [JsonIgnore] public virtual Guid TargetPersonId => this.PersonId;
    }
}