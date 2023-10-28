using AgencyPro.Common.Enums;
using AgencyPro.Common.EventHandling;
using AgencyPro.Common.Settings;

namespace AgencyPro.Common.Events
{
    public abstract class BaseEvent : IEvent
    {
       
        public ModelType ModelType { get; set; }
        public ModelAction Action { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public AppInformation AppInfo { get; set; }
        public AppBaseUrls Urls { get; set; }
    }
}