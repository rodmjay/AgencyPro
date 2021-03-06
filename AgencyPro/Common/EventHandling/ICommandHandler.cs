﻿namespace AgencyPro.Common.EventHandling
{
    public interface ICommandHandler
    {
    }

    public interface ICommandHandler<in TCommand> : ICommandHandler
        where TCommand : ICommand
    {
        void Handle(TCommand cmd);
    }
}