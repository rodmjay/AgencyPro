using System;
using AgencyPro.Proposals.Enums;

namespace AgencyPro.Proposals.Models
{
    public class ProposalAcceptanceOutput
    {
        public DateTimeOffset AcceptedCompletionDate { get; set; }

        public Guid Id { get; set; }

        public decimal TotalCost { get; set; }

        public int NetTerms { get; set; }

        public string ProposalBlob { get; set; }
        public decimal CustomerRate { get; set; }
        public decimal TotalDays { get; set; }
        public string AgreementText { get; set; }
        public ProposalType ProposalType { get; set; }
    }
}
