using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.PaymentTerms.Entities;
using AgencyPro.PaymentTerms.Models;

namespace AgencyPro.PaymentTerms.Interfaces
{
    public interface IPaymentTermService : IService<PaymentTerm>
    {
        Task<List<PaymentTermOutput>> GetPaymentTermsByCategory(int categoryId);
        Task<List<PaymentTermOutput>> GetPaymentTermsByOrganization(Guid organizationId);
        Task<bool> AddPaymentTermToOrganization(IAgencyOwner ao, int paymentTermId);
        Task<bool> AddPaymentTermToOrganization(IOrganizationAccountManager am, int paymentTermId);
        Task<bool> RemovePaymentFromOrganization(IAgencyOwner ao, int paymentTermId);
        Task<bool> RemovePaymentFromOrganization(IOrganizationAccountManager ao, int paymentTermId);
    }
}
