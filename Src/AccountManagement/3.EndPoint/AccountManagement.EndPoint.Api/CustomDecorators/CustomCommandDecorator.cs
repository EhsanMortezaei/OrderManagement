﻿using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.EndPoint.Api.CustomDecorators;

//
public sealed class CustomCommandDecorator : CommandDispatcherDecorator
{
    public override int Order => 0;

    public override async Task<CommandResult> Send<TCommand>(TCommand command)
    {
        return await _commandDispatcher.Send(command);
    }

    public override async Task<CommandResult<TData>> Send<TCommand, TData>(TCommand command)
    {
        return await _commandDispatcher.Send<TCommand, TData>(command);
    }
}