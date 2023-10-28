namespace AgencyPro.Transfers.Interfaces
{
    public interface IStripeTransfer
    {
        string Id { get; set; }
        decimal Amount { get; set; }
        decimal AmountReversed { get; set; }
        string Description { get; set; }
        string DestinationId { get; set; }
        string DestinationPaymentId { get; set; }
    }
}