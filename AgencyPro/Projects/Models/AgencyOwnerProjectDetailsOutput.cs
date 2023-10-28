using System;
using System.Collections.Generic;
using AgencyPro.BillingCategories.Models;
using AgencyPro.Comments.Models;
using AgencyPro.Contracts.Enums;
using AgencyPro.Contracts.Models;
using AgencyPro.Invoices.Models;
using AgencyPro.PaymentTerms.Models;
using AgencyPro.Projects.Enums;
using AgencyPro.Proposals.Models;
using AgencyPro.Stories.Enums;
using AgencyPro.Stories.Models;
using AgencyPro.TimeEntries.Enums;

namespace AgencyPro.Projects.Models
{
    public class AgencyOwnerProjectDetailsOutput : AgencyOwnerProjectOutput
    {
        public AgencyOwnerFixedPriceProposalModel Proposal { get; set; }
        public ICollection<AgencyOwnerProviderContractOutput> Contracts { get; set; }
        public ICollection<AgencyOwnerStoryOutput> Stories { get; set; }
        public ICollection<AgencyOwnerProjectInvoiceOutput> Invoices { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }

        public Dictionary<DateTimeOffset, ProjectStatus> StatusTransitions { get; set; }
        public IDictionary<TimeStatus, int> TimeEntryStatus { get; set; }
        public IDictionary<StoryStatus, int> StoryStatus { get; set; }
        public IDictionary<ContractStatus, int> ContractStatus { get; set; }

        public ICollection<BillingCategoryOutput> AvailableBillingCategories { get; set; }
        public ICollection<PaymentTermOutput> AvailablePaymentTerms { get; set; }
        public ICollection<int> BillingCategoryIds { get; set; }
    }
}