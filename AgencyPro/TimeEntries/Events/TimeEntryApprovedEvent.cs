namespace AgencyPro.TimeEntries.Events
{
    public class TimeEntryApprovedEvent : TimeEntryEvent
    {
        // co

        public override string ToString()
        {
            return "timeentry.approved";
        }
    }
}