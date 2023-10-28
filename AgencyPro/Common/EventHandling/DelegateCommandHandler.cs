using System;

namespace AgencyPro.Common.EventHandling
{
    public class DelegateCommandHandler<TCommand> : ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        private readonly Action<TCommand> _action;

        public DelegateCommandHandler(Action<TCommand> action)
        {
            _action = action;
        }

        public void Handle(TCommand cmd)
        {
            _action(cmd);
        }
    }
}