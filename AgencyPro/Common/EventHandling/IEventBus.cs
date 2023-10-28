namespace AgencyPro.Common.EventHandling
{
    public interface IEventBus
    {
        void RaiseEvent(IEvent evt);
    }
}