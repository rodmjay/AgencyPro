using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace AgencyPro.Common.EventHandling
{
    public class EventBus : List<IEventHandler>, IEventBus
    {
        private readonly GenericMethodActionBuilder<IEventHandler, IEvent> _actions =
            new GenericMethodActionBuilder<IEventHandler, IEvent>(typeof(IEventHandler<>), "Handle");

        private readonly ConcurrentDictionary<Type, IEnumerable<IEventHandler>> _handlerCache =
            new ConcurrentDictionary<Type, IEnumerable<IEventHandler>>();

        public void RaiseEvent(IEvent evt)
        {
            var action = GetAction(evt);
            var matchingHandlers = GetHandlers(evt);
            foreach (var handler in matchingHandlers) action(handler, evt);
        }

        private Action<IEventHandler, IEvent> GetAction(IEvent evt)
        {
            return _actions.GetAction(evt);
        }

        private IEnumerable<IEventHandler> GetHandlers(IEvent evt)
        {
            var eventType = evt.GetType();
            if (_handlerCache.ContainsKey(eventType)) return _handlerCache[eventType];
            var eventHandlerType = typeof(IEventHandler<>).MakeGenericType(eventType);
            var query =
                from handler in this
                where eventHandlerType.IsInstanceOfType(handler)
                select handler;
            var handlers = query.ToArray();
            _handlerCache[eventType] = handlers;
            return _handlerCache[eventType];
        }
    }
}