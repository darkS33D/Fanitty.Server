﻿using Fanitty.Server.Application.Users.Commands.CreateUser;
using MediatR;

namespace Fanitty.Server.API.Endpoints.Users;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this WebApplication app)
    {
        var userEndpoints = app.MapGroup("/users");

        userEndpoints.MapPost("/",
            async (CreateUserCommand command, IMediator mediator, CancellationToken cancellationToken)
            => await mediator.Send(command, cancellationToken));
    }
}
