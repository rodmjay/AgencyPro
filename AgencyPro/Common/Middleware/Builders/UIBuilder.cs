#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using AgencyPro.Common.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace AgencyPro.Common.Middleware.Builders;

public class UIBuilder
{
    public UIBuilder(WebAppBuilder serviceBuilder)
    {
        Services = serviceBuilder.Services;
        AppSettings = serviceBuilder.AppSettings;
    }

    public AppSettings AppSettings { get; }
    public IServiceCollection Services { get; }
}