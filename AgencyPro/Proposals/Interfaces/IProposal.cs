using System;
using AgencyPro.Proposals.Enums;

namespace AgencyPro.Proposals.Interfaces
{
    public interface IProposal
    {
       
        Guid Id { get; set; }
        decimal VelocityBasis { get; set; }
        decimal WeeklyMaxHourBasis { get; set; }
        string AgreementText { get; set; }
        decimal? BudgetBasis { get; set; }
        ProposalStatus Status { get; set; }
        ProposalType ProposalType { get; set; }
    }
}