using AgencyPro.Common.Enums;

namespace AgencyPro.Common.Events
{
    public abstract class ExceptionLogEvent : BaseEvent
    {
        protected ExceptionLogEvent()
        {
            ModelType = ModelType.ExceptionLog;
        }

        public int ExceptionLogId { get; set; }
        public ExceptionLog.ExceptionLog Exception { get; set; }
    }
}