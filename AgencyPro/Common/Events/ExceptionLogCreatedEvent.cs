namespace AgencyPro.Common.Events
{
    public class ExceptionLogCreatedEvent : ExceptionLogEvent
    {
        public ExceptionLogCreatedEvent(ExceptionLog.ExceptionLog err)
        {
            Exception = err;
        }
    }
}