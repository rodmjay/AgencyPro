using System;
using AgencyPro.People.Enums;
using AgencyPro.People.Interfaces;

namespace AgencyPro.People.Models
{
    public class PersonOutput : PersonInput, IPerson
    {
        public virtual bool IsCustomer { get; set; }
        public virtual bool IsContractor { get; set; }
        public virtual bool IsAccountManager { get; set; }
        public virtual bool IsProjectManager { get; set; }
        public virtual bool IsRecruiter { get; set; }
        public virtual bool IsMarketer { get; set; }
        public virtual Guid Id { get; set; }

        public virtual string ImageUrl { get; set; }
        public virtual string City { get; set; }
        
        public virtual PersonStatus Status { get; set; }
        public virtual DateTimeOffset Created { get; set; }
        public virtual DateTimeOffset Updated { get; set; }
    }
}