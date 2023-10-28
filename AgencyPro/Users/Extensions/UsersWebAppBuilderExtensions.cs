﻿#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System;
using AgencyPro.Common.Middleware.Builders;
using AgencyPro.Users.Interfaces;
using AgencyPro.Users.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace AgencyPro.Users.Extensions;

public static class UsersWebAppBuilderExtensions
{
    public static WebAppBuilder AddSession(this WebAppBuilder builder)
    {
        builder.Services.AddSession(options =>
        {
            //options.IdleTimeout = TimeSpan.FromSeconds(1000);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });
        return builder;
    }

    public static WebAppBuilder AddUserAccessor(this WebAppBuilder builder)
    {
        builder.Services.TryAddScoped<IUserAccessor, UserAccessor>();
        builder.Services.TryAddScoped(x =>
        {
            var httpContextAccessor = x.GetRequiredService<IHttpContextAccessor>();
            var userAccessor = x.GetRequiredService<IUserAccessor>();

            return userAccessor.GetUser(httpContextAccessor.HttpContext.User).Result;
        });

        return builder;
    }

    public static WebAppBuilder AddAuthorization(this WebAppBuilder builder,
        Action<AuthorizationPolicyBuilder> action)
    {
        builder.Services.AddAuthorization(options => { options.AddPolicy("ApiScope", action); });

        return builder;
    }
}