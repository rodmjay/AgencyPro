using AgencyPro.Invoices.Emails;
using AgencyPro.Invoices.Entities;

namespace AgencyPro.Invoices.Projections
{
    public partial class InvoiceProjections
    {
        private void ConfigureEmails()
        {
            CreateMap<ProjectInvoice, AgencyOwnerInvoiceEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.ProviderOrganization.Customer.Person.User.SendMail))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.ProviderOrganization.Customer.Person.FirstName))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.ProviderOrganization.Customer.Person.User.Email));


            CreateMap<ProjectInvoice, CustomerInvoiceEmail>()
                .ForMember(x => x.SendMail,
                    opt => opt.MapFrom(x =>
                        x.Customer.Person.User
                            .SendMail))
                .ForMember(x => x.RecipientEmail,
                    opt => opt.MapFrom(x =>
                        x.Customer.Person.User
                            .Email))
                .ForMember(x => x.RecipientName,
                    opt => opt.MapFrom(x =>
                        x.Customer.Person
                            .FirstName)); ;
            
            CreateMap<ProjectInvoice, AccountManagerInvoiceEmail>()
                .ForMember(x => x.SendMail,
                    opt => opt.MapFrom(x =>
                        x.AccountManager.Person.User
                            .SendMail))
                .ForMember(x => x.RecipientEmail,
                    opt => opt.MapFrom(x =>
                        x.AccountManager.Person.User
                            .Email))
                .ForMember(x => x.RecipientName,
                    opt => opt.MapFrom(x =>
                        x.AccountManager.Person.FirstName));
        }
    }
}