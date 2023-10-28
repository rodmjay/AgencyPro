﻿#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.IO;
using AgencyPro.Common.Data.Contexts;
using AgencyPro.Common.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AgencyPro.Common.Data.Factories;

public class OperationalContextFactory : IApplicationContextFactory
{
    public ApplicationContext CreateDbContext(string[] args)
    {
        // Used only for EF .NET Core CLI tools (update database/migrations etc.)
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
            .AddJsonFile("sharedSettings.json", false, true);

        var config = builder.Build();

        var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>()
            .EnableSensitiveDataLogging()
            .UseSqlServer(config.GetConnectionString("DefaultConnection"));

        return new ApplicationContext(optionsBuilder.Options);
    }
}