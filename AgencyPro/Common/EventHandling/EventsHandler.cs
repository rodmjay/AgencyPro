namespace AgencyPro.Common.EventHandling
{
    public class EventsHandler
    {
        private readonly EventBus _eventBus = new EventBus();

        private readonly EventBus _validationBus = new EventBus();

        public IEventBus EventBus => _eventBus;

        public IEventBus ValidationBus => _validationBus;

        public void AddEventHandler(params IEventHandler[] handlers)
        {
            foreach (var h in handlers) VerifyHandler(h);
            _eventBus.AddRange(handlers);
        }

        public void AddValidationHandler(params IEventHandler[] handlers)
        {
            _validationBus.AddRange(handlers);
        }

        private static void VerifyHandler(IEventHandler e)
        {
            var type = e.GetType();
            var interfaces = type.GetInterfaces();
            foreach (var itf in interfaces)
            {
                if (!itf.IsConstructedGenericType || itf.GetGenericTypeDefinition() != typeof(IEventHandler<>))
                    continue;
                var eventHandlerType = itf.GetGenericArguments()[0];
                if (!eventHandlerType.IsConstructedGenericType) continue;
                var targetUserAccountType = eventHandlerType.GetGenericArguments()[0];

                //var isSameType = targetUserAccountType == typeof(UserAccount);
                //if (!isSameType)
                //{
                //    throw new ArgumentException(string.Format("Event handler: {0} must handle events for User Account type: {1}",
                //        e.GetType().FullName,
                //        typeof(UserAccount).FullName));
                //}
            }
        }
    }
}