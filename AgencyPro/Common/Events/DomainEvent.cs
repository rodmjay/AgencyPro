using AgencyPro.Common.Enums;
using AgencyPro.Common.Extensions;


namespace AgencyPro.Common.Events
{
    public class DomainEvent
    {
        public DomainEvent(ModelType domain, ModelAction action)
            : this(domain, action, null)
        {
        }

        public DomainEvent(string domain, string action)
            : this(domain, action, null)
        {
        }

        public DomainEvent(string domain, string action, object data)
        {
            Module = domain;
            Action = action;
            Data = data;
        }

        public DomainEvent(ModelType domain, ModelAction action, object data)
        {
            Module = domain.GetName();
            Action = action.GetName();
            Data = data;
        }

        public string Module { get; set; }

        public string Action { get; set; }

        public int? UserId { get; set; }

        public object Data { get; set; }
    }
}