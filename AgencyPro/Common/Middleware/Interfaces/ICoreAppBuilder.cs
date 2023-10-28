#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Collections.Generic;
using AgencyPro.Common.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AgencyPro.Common.Middleware.Interfaces;

public interface ICoreAppBuilder
{
    IServiceCollection Services { get; }
    AppSettings AppSettings { get; }
    IConfiguration Configuration { get; }
    string ConnectionString { get; set; }
    List<string> AssembliesToMap { get; set; }
}