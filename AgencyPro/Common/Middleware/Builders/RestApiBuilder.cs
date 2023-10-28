#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using AgencyPro.Common.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace AgencyPro.Common.Middleware.Builders;

public class RestApiBuilder
{
    public RestApiBuilder(WebAppBuilder serviceBuilder)
    {
        Services = serviceBuilder.Services;
        AppSettings = serviceBuilder.AppSettings;
        ConnectionString = serviceBuilder.ConnectionString;
    }

    public string ConnectionString { get; set; }
    public AppSettings AppSettings { get; }
    public IServiceCollection Services { get; }
}