﻿#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System;
using System.Threading.Tasks;
using AgencyPro.Common.Settings;
using AgencyPro.Users.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace AgencyPro.Common.Middleware.Bases;

[ApiController]
[Produces("application/json")]
[Route("v1.0/[controller]")]
public class BaseController : ControllerBase
{
    private readonly IUserAccessor _userAccessor;
    protected readonly AppSettings AppSettings;
    protected readonly IDistributedCache Cache;
    //protected readonly IPermissionService PermissionService;

    /// <param name="serviceProvider"></param>
    protected BaseController(IServiceProvider serviceProvider)
    {
        _userAccessor = serviceProvider.GetService<IUserAccessor>();
        //PermissionService = serviceProvider.GetRequiredService<IPermissionService>();
        Cache = serviceProvider.GetRequiredService<IDistributedCache>();
        AppSettings = serviceProvider.GetRequiredService<IOptions<AppSettings>>().Value;
    }
    

    protected async Task<IUser> GetCurrentUser()
    {
        return await _userAccessor.GetUser(User);
    }
}