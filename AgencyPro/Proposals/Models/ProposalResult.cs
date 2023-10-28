using System;
using AgencyPro.Common.Models;

namespace AgencyPro.Proposals.Models
{

    public class ProposalResult : Result
    {
        public Guid ProposalId { get; set; }
        public string ProposalPdfUrl { get; set; }
    }
}