using System;

namespace AgencyPro.Common.EventHandling
{
    public static class DomainEvents
    {
        static DomainEvents()
        {
            Dispatcher = new EmptyDispatcher();
        }

        public static IEventDispatcher Dispatcher { get; set; }

        public static void Raise<TEvent>(TEvent e)
        {
            if (e != null) Dispatcher.Dispatch(e);
        }

        private class EmptyDispatcher : IEventDispatcher
        {
            public void Resolve()
            {
                throw new NotImplementedException();
            }

            public void Dispatch<TEvent>(TEvent e)
            {
            }
        }
    }
}