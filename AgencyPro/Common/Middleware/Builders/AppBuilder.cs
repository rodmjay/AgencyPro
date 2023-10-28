#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Collections.Generic;
using AgencyPro.Common.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AgencyPro.Common.Middleware.Builders;

public class AppBuilder
{
    public AppBuilder(
        IServiceCollection services,
        AppSettings settings,
        IConfiguration configuration)
    {
        Services = services;
        Configuration = configuration;
        AppSettings = settings;
        AssembliesToMap = new List<string>();
    }

    public List<string> AssembliesToMap { get; set; }
    public IServiceCollection Services { get; }
    public IConfiguration Configuration { get; }
    public string ConnectionString { get; set; }
    public AppSettings AppSettings { get; set; }
}