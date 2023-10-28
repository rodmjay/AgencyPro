namespace AgencyPro.TimeEntries.Events
{
    public class TimeEntryRejectedEvent : TimeEntryEvent
    {
        public override string ToString()
        {
            return "timeentry.rejected";
        }
    }
}