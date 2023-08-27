﻿using Fanitty.Server.Core.Events;
using MediatR;

namespace Fanitty.Server.Application.Users.EventHandlers;

public class UserCreatedEventHandler : INotificationHandler<UserCreatedEvent>
{
    public Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
    {

        return Task.CompletedTask;
    }
}
