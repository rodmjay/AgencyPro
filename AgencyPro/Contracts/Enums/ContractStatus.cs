namespace AgencyPro.Contracts.Enums
{
    public enum ContractStatus : byte
    {
        Pending = 0,
        Active = 1,
        Paused = 2,
        Ended = 4,
        Inactive = Paused | Ended

    }
}