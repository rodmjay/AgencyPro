namespace AgencyPro.Common.EventHandling
{
    public interface IEventDispatcher
    {
        void Resolve();
        void Dispatch<TEvent>(TEvent e);
    }
}