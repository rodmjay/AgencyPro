namespace AgencyPro.Invoices.Enums
{
    public enum InvoiceStatus : byte
    {
        Draft = 0,
        Sent = 1,
        Paid = 2,
        PartialPayment = 3,
        Deleted = 4
    }
}