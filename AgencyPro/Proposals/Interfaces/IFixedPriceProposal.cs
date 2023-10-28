namespace AgencyPro.Proposals.Interfaces
{
    public interface IFixedPriceProposal : IProposal
    {
        int StoryPointBasis { get; set; }
        int EstimationBasis { get; set; }
        decimal OtherPercentBasis { get; set; }
        int ExtraDayBasis { get; set; }
        decimal CustomerRateBasis { get; set; }
        int StoryHours { get; set; }
        decimal TotalHours { get; set; }
        decimal TotalPriceQuoted { get; set; }
    }
}