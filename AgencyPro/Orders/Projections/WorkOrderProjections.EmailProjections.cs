using AgencyPro.Orders.Emails;
using AgencyPro.Orders.Entities;

namespace AgencyPro.Orders.Projections
{
    public partial class WorkOrderProjections
    {
        private void EmailProjections()
        {
            CreateMap<WorkOrder, AccountManagerWorkOrderEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.AccountManager.Person.User.SendMail))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.AccountManager.Person.User.Email))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.AccountManager.Person.DisplayName));

            CreateMap<WorkOrder, AgencyOwnerWorkOrderEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.OrganizationAccountManager.Organization.Customer.Person.User.SendMail))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.OrganizationAccountManager.Organization.Customer.Person.User.Email))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.OrganizationAccountManager.Organization.Customer.Person.DisplayName));

            CreateMap<WorkOrder, CustomerWorkOrderEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.BuyerOrganization.Customer.Person.User.SendMail))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.BuyerOrganization.Customer.Person.User.Email))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.BuyerOrganization.Customer.Person.DisplayName));

        }
    }
}