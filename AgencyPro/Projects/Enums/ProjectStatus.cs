namespace AgencyPro.Projects.Enums
{
    public enum ProjectStatus
    {
        Pending = 0,
        Active = 1,
        Paused = 2,
        Ended = 4,
        Inactive = Paused | Ended
    }
}