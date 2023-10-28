using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Notifications.Entities;
using AgencyPro.Orders.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.Proposals.Enums;
using AgencyPro.Proposals.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Proposals.Entities
{
    public class FixedPriceProposal : BaseEntity<FixedPriceProposal>, IFixedPriceProposal
    {
        [ForeignKey("Id")] public Project Project { get; set; }
        public ProposalAcceptance ProposalAcceptance { get; set; }

        public ICollection<ProposalWorkOrder> WorkOrders { get; set; }
        public ICollection<ProposalNotification> Notifications { get; set; }

        private ICollection<ProposalStatusTransition> _statusTransitions;

        public virtual ICollection<ProposalStatusTransition> StatusTransitions
        {
            get => _statusTransitions ??= new Collection<ProposalStatusTransition>();
            set => _statusTransitions = value;
        }

        public Guid Id { get; set; }

        public decimal VelocityBasis { get; set; }

        public decimal WeeklyMaxHourBasis { get; set; }

        public string AgreementText { get; set; }

        public decimal? BudgetBasis { get; set; }

        public ProposalStatus Status { get; set; }

        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }

        public string ConcurrencyStamp { get; set; }
        
        public ProposalType ProposalType { get; set; }

        public decimal WeeklyCapacity
        {
            get => WeeklyMaxHourBasis * VelocityBasis;
            set { }
        }

        public decimal DailyCapacity
        {
            get => WeeklyCapacity / 7;
            set { }
        }

        public int StoryPointBasis { get; set; }

        public int EstimationBasis { get; set; }

        public decimal OtherPercentBasis { get; set; }

        public int ExtraDayBasis { get; set; }

        public decimal CustomerRateBasis { get; set; }

        public int StoryHours
        {
            get => StoryPointBasis * EstimationBasis;
            set { }
        }

        public decimal TotalHours
        {
            get => StoryHours * (1 + OtherPercentBasis);
            set { }
        }

        public decimal TotalPriceQuoted
        {
            get => TotalHours * CustomerRateBasis;
            set { }
        }

        public decimal TotalDays
        {
            get => (TotalHours / DailyCapacity) + ExtraDayBasis;
            set { }
        }

        public decimal RetainerPercent { get; set; }

        public override void Configure(EntityTypeBuilder<FixedPriceProposal> builder)
        {
            throw new NotImplementedException();
        }
    }
}