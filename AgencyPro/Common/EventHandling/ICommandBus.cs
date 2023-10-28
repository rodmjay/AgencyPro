namespace AgencyPro.Common.EventHandling
{
    public interface ICommandBus
    {
        void Execute(ICommand cmd);
    }
}