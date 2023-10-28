namespace AgencyPro.TimeEntries.Events
{
    public class TimeEntryLoggedEvent : TimeEntryEvent
    {
        // pm 

        public override string ToString()
        {
            return "timeentry.logged";
        }
    }
}