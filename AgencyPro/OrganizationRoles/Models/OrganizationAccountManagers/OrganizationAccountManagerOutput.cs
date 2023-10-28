using AgencyPro.People.Enums;

namespace AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers
{
    public class OrganizationAccountManagerOutput : OrganizationAccountManagerInput
    {
        public virtual string DisplayName { get; set; }
        public virtual string ImageUrl { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual PersonStatus Status { get; set; }
    }
}