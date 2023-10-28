using AgencyPro.Invoices.Entities;
using AgencyPro.Invoices.Models;
using AgencyPro.Stripe.Entities;
using AutoMapper;

namespace AgencyPro.Invoices.Projections
{
    public partial class InvoiceProjections : Profile
    {
        public InvoiceProjections()
        {
            CreateMap<StripeInvoice, ProjectInvoiceOutput>()
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.StripeCustomerId, opt => opt.MapFrom(x => x.CustomerId))
                .ForMember(x => x.AmountPaid, opt => opt.MapFrom(x => x.AmountPaid))
                .ForMember(x => x.Total, opt => opt.MapFrom(x => x.Total))
                .ForMember(x => x.Subtotal, opt => opt.MapFrom(x => x.Subtotal))
                .ForMember(x => x.EndingBalance, opt => opt.MapFrom(x => x.EndingBalance))
                .ForMember(x => x.HostedInvoiceUrl, opt => opt.MapFrom(x => x.HostedInvoiceUrl))
                .ForMember(x => x.InvoicePdf, opt => opt.MapFrom(x => x.InvoicePdf))
                .ForMember(x => x.AmountRemaining, opt => opt.MapFrom(x => x.AmountRemaining))
                .ForMember(x => x.AmountDue, opt => opt.MapFrom(x => x.AmountDue))
                .ForMember(x => x.CustomerId, opt => opt.Ignore())
                .ForMember(x => x.DueDate, opt => opt.MapFrom(x => x.DueDate))
                .ForMember(x => x.Number, opt => opt.MapFrom(x => x.Number))
                .ForMember(x => x.Status, opt => opt.MapFrom(x => x.Status))
                .ForMember(x => x.CustomerId, opt => opt.MapFrom(x => x.ProjectInvoice.CustomerId))
                .ForMember(x => x.CustomerName, opt => opt.MapFrom(x => x.ProjectInvoice.CustomerId))
                .ForMember(x => x.CustomerAddressLine1, opt => opt.MapFrom(x => x.ProjectInvoice.BuyerOrganization.AddressLine1))
                .ForMember(x => x.CustomerAddressLine2, opt => opt.MapFrom(x => x.ProjectInvoice.BuyerOrganization.AddressLine2))
                .ForMember(x => x.CustomerCity, opt => opt.MapFrom(x => x.ProjectInvoice.BuyerOrganization.City))
                .ForMember(x => x.CustomerStateProvince, opt => opt.MapFrom(x => x.ProjectInvoice.BuyerOrganization.ProvinceState))
                .ForMember(x => x.CustomerIso2, opt => opt.MapFrom(x => x.ProjectInvoice.BuyerOrganization.Iso2))
                .ForMember(x => x.CustomerPostalCode, opt => opt.MapFrom(x => x.ProjectInvoice.BuyerOrganization.PostalCode))
                .IncludeAllDerived();

            CreateMap<ProjectInvoice, ProjectInvoiceOutput>()
                .IncludeMembers(x => x.Invoice)
                .ForMember(x => x.CustomerAddressLine1, opt => opt.MapFrom(x => x.BuyerOrganization.AddressLine1))
                .ForMember(x => x.CustomerAddressLine2, opt => opt.MapFrom(x => x.BuyerOrganization.AddressLine2))
                .ForMember(x => x.CustomerCity, opt => opt.MapFrom(x => x.BuyerOrganization.City))
                .ForMember(x => x.CustomerStateProvince, opt => opt.MapFrom(x => x.BuyerOrganization.ProvinceState))
                .ForMember(x => x.CustomerIso2, opt => opt.MapFrom(x => x.BuyerOrganization.Iso2))
                .ForMember(x => x.CustomerPostalCode, opt => opt.MapFrom(x => x.BuyerOrganization.PostalCode))
                .ForMember(x => x.CustomerId, opt => opt.MapFrom(x => x.CustomerId))
                .ForMember(x => x.CustomerOrganizationId, opt => opt.MapFrom(x => x.BuyerOrganizationId))
                .ForMember(x => x.CustomerName, opt => opt.MapFrom(x => x.Customer.Person.DisplayName))
                .ForMember(x => x.CustomerEmail, opt => opt.MapFrom(x => x.Customer.Person.User.Email))
                .ForMember(x => x.CustomerPhoneNumber, opt => opt.MapFrom(x => x.Customer.Person.User.PhoneNumber))
                .ForMember(x => x.CustomerImageUrl, opt => opt.MapFrom(x => x.Customer.Person.ImageUrl))
                .ForMember(x => x.CustomerOrganizationImageUrl, opt => opt.MapFrom(x => x.BuyerOrganization.ImageUrl))
                .ForMember(x => x.CustomerOrganizationName, o => o.MapFrom(x => x.BuyerOrganization.Name))
                .ForMember(x => x.AccountManagerImageUrl, opt => opt.MapFrom(x => x.AccountManager.Person.ImageUrl))
                .ForMember(x => x.AccountManagerName, opt => opt.MapFrom(x => x.AccountManager.Person.DisplayName))
                .ForMember(x => x.AccountManagerEmail, opt => opt.MapFrom(x => x.AccountManager.Person.User.Email))
                .ForMember(x => x.AccountManagerPhoneNumber, opt => opt.MapFrom(x => x.AccountManager.Person.User.PhoneNumber))
                .ForMember(x => x.AccountManagerId, opt => opt.MapFrom(x => x.AccountManagerId))
                .ForMember(x => x.AccountManagerOrganizationImageUrl, opt => opt.MapFrom(x => x.ProviderOrganization.ImageUrl))
                .ForMember(x => x.AccountManagerOrganizationName, opt => opt.MapFrom(x => x.ProviderOrganization.Name))
                .ForMember(x => x.AccountManagerOrganizationId, opt => opt.MapFrom(x => x.ProviderOrganizationId))
                .ForMember(x => x.ProjectManagerImageUrl, opt => opt.MapFrom(x => x.ProjectManager.Person.ImageUrl))
                .ForMember(x => x.ProjectManagerName, opt => opt.MapFrom(x => x.ProjectManager.Person.DisplayName))
                .ForMember(x => x.ProjectManagerId, opt => opt.MapFrom(x => x.ProjectManagerId))
                .ForMember(x => x.ProjectManagerOrganizationId, opt => opt.MapFrom(x => x.ProviderOrganizationId))
                .ForMember(x => x.ProjectManagerOrganizationImageUrl, opt => opt.MapFrom(x => x.ProviderOrganization.ImageUrl))
                .ForMember(x => x.ProjectManagerOrganizationName, opt => opt.MapFrom(x => x.OrganizationProjectManager.Organization.Name))

                .ForMember(x => x.ProjectName, opt => opt.MapFrom(x => x.Project.Name))

                .ForMember(x => x.RefNo, o => o.MapFrom(x => x.RefNo))
                .ForMember(x => x.Id, o => o.MapFrom(x => x.InvoiceId))

                .IncludeAllDerived();

            CreateMap<ProjectInvoice, AgencyOwnerProjectInvoiceOutput>()
                .IncludeAllDerived();

            CreateMap<StripeInvoice, AgencyOwnerProjectInvoiceOutput>()
                .IncludeAllDerived();

            CreateMap<StripeInvoice, AccountManagerProjectInvoiceOutput>().IncludeAllDerived();
            CreateMap<StripeInvoice, ManagerProjectInvoiceOutput>().IncludeAllDerived();
            CreateMap<StripeInvoice, ContractorProjectInvoiceOutput>().IncludeAllDerived();
            CreateMap<StripeInvoice, CustomerProjectInvoiceOutput>().IncludeAllDerived();

            CreateMap<StripeInvoice, AgencyOwnerProjectInvoiceDetailsOutput>()
                .ForMember(x => x.IndividualPayoutIntents, opt => opt.MapFrom(x => x.IndividualPayoutIntents))
                .ForMember(x => x.OrganizationPayoutIntents, opt => opt.MapFrom(x => x.OrganizationPayoutIntents))
                .ForMember(x => x.Items, opt => opt.MapFrom(x => x.Items))
                .ForMember(x => x.Transfers, opt => opt.MapFrom(x => x.InvoiceTransfers))
                .ForMember(x => x.Charges, opt => opt.MapFrom(x => x.PaymentIntent.Charges))
                .ForMember(x => x.Lines, opt => opt.MapFrom(x => x.Lines));

            CreateMap<StripeInvoice, AccountManagerProjectInvoiceDetailsOutput>()
                .ForMember(x => x.IndividualPayoutIntents, opt => opt.MapFrom(x => x.IndividualPayoutIntents))
                .ForMember(x => x.OrganizationPayoutIntents, opt => opt.MapFrom(x => x.OrganizationPayoutIntents))
                .ForMember(x => x.Items, opt => opt.MapFrom(x => x.Items))
                .ForMember(x => x.Transfers, opt => opt.MapFrom(x => x.InvoiceTransfers))
                .ForMember(x => x.Charges, opt => opt.MapFrom(x => x.PaymentIntent.Charges))
                .ForMember(x => x.Lines, opt => opt.MapFrom(x => x.Lines));

            CreateMap<StripeInvoice, ManagerProjectInvoiceDetailsOutput>()
                .ForMember(x => x.Lines, opt => opt.MapFrom(x => x.Lines));

            CreateMap<StripeInvoice, ContractorProjectInvoiceDetailsOutput>()
                .ForMember(x => x.Lines, opt => opt.MapFrom(x => x.Lines));

            CreateMap<StripeInvoice, CustomerProjectInvoiceDetailsOutput>()
                .ForMember(x => x.Lines, opt => opt.MapFrom(x => x.Lines));

            CreateMap<ProjectInvoice, AccountManagerProjectInvoiceOutput>()
                .IncludeMembers(x => x.Invoice)
                .IncludeAllDerived();

            CreateMap<ProjectInvoice, ManagerProjectInvoiceOutput>()
                .IncludeMembers(x => x.Invoice)
                .IncludeAllDerived();

            CreateMap<ProjectInvoice, ContractorProjectInvoiceOutput>()
                .IncludeMembers(x => x.Invoice)
                .IncludeAllDerived();

            CreateMap<ProjectInvoice, CustomerProjectInvoiceOutput>()
                .IncludeMembers(x => x.Invoice)
                .IncludeAllDerived();

            CreateMap<ProjectInvoice, AgencyOwnerProjectInvoiceDetailsOutput>()
                .ForMember(x => x.IndividualPayoutIntents, opt => opt.MapFrom(x => x.Invoice.IndividualPayoutIntents))
                .ForMember(x => x.OrganizationPayoutIntents, opt => opt.MapFrom(x => x.Invoice.OrganizationPayoutIntents))
                .ForMember(x => x.Items, opt => opt.MapFrom(x => x.Invoice.Items))
                .ForMember(x => x.Transfers, opt => opt.MapFrom(x => x.Invoice.InvoiceTransfers))
                .ForMember(x => x.Charges, opt => opt.MapFrom(x => x.Invoice.PaymentIntent.Charges))
                .ForMember(x => x.Lines, opt => opt.MapFrom(x => x.Invoice.Lines));

            CreateMap<ProjectInvoice, AccountManagerProjectInvoiceDetailsOutput>()
                .ForMember(x => x.IndividualPayoutIntents, opt => opt.MapFrom(x => x.Invoice.IndividualPayoutIntents))
                .ForMember(x => x.OrganizationPayoutIntents, opt => opt.MapFrom(x => x.Invoice.OrganizationPayoutIntents))
                .ForMember(x => x.Items, opt => opt.MapFrom(x => x.Invoice.Items))
                .ForMember(x => x.Transfers, opt => opt.MapFrom(x => x.Invoice.InvoiceTransfers))
                .ForMember(x => x.Charges, opt => opt.MapFrom(x => x.Invoice.PaymentIntent.Charges))
                .ForMember(x => x.Lines, opt => opt.MapFrom(x => x.Invoice.Lines));

            CreateMap<ProjectInvoice, ManagerProjectInvoiceDetailsOutput>()
                .ForMember(x => x.Lines, opt => opt.MapFrom(x => x.Invoice.Lines));

            CreateMap<ProjectInvoice, ContractorProjectInvoiceDetailsOutput>()
                .ForMember(x => x.Lines, opt => opt.MapFrom(x => x.Invoice.Lines));

            CreateMap<ProjectInvoice, CustomerProjectInvoiceDetailsOutput>()
                .ForMember(x => x.Lines, opt => opt.MapFrom(x => x.Invoice.Lines));

            ConfigureItemMappings();
            ConfigureLineMappings();
            ConfigureEmails();
        }

        private void ConfigureItemMappings()
        {
            CreateMap<StripeInvoiceItem, InvoiceItemOutput>()
                .ForMember(x => x.ContractId, opt => opt.MapFrom(x => x.ContractId))
                .ForMember(x => x.CustomerId, opt => opt.MapFrom(x => x.CustomerId))
                .ForMember(x => x.PeriodEnd, opt => opt.MapFrom(x => x.PeriodEnd))
                .ForMember(x => x.PeriodStart, opt => opt.MapFrom(x => x.PeriodStart))
                .ForMember(x => x.Quantity, opt => opt.MapFrom(x => x.Quantity))
                .ForMember(x => x.Updated, opt => opt.MapFrom(x => x.Updated))
                .ForMember(x => x.Description, opt => opt.MapFrom(x => x.Description))
                .ForMember(x => x.Amount, opt => opt.MapFrom(x => x.Amount))
                .ForMember(x => x.Created, opt => opt.MapFrom(x => x.Created))
                .ForMember(x => x.InvoiceId, opt => opt.MapFrom(x => x.InvoiceId))
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id));
        }

        private void ConfigureLineMappings()
        {
            CreateMap<StripeInvoiceLine, InvoiceLineOutput>()
                .ForMember(x => x.Currency, opt => opt.MapFrom(x => x.Currency))
                .ForMember(x => x.InvoiceId, opt => opt.MapFrom(x => x.InvoiceId))
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id));
        }
    }
}