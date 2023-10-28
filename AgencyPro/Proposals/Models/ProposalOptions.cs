namespace AgencyPro.Proposals.Models
{
    public class ProposalOptions
    {
        public virtual int? StoryPointBasis { get; set; }
        public virtual int? EstimationBasis { get; set; }
        public virtual decimal OtherPercentBasis { get; set; }
        public virtual decimal? CustomerRateBasis { get; set; }
        public virtual decimal VelocityBasis { get; set; } = 1m;
        public virtual decimal? WeeklyMaxHourBasis { get; set; }
        public virtual string AgreementText { get; set; }
        public virtual decimal? BudgetBasis { get; set; }
        public virtual bool RequiresRetainer { get; set; }
        public virtual decimal? RetainerPercent { get; set; }

        public int[] WorkOrderIds { get; set; }
    }
}