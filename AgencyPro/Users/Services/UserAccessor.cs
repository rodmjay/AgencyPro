#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AgencyPro.Common.Services.Bases;
using AgencyPro.Users.Entities;
using AgencyPro.Users.Interfaces;
using AgencyPro.Users.Managers;
using AgencyPro.Users.Models;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace AgencyPro.Users.Services;

public class UserAccessor : BaseService<User>, IUserAccessor
{
    private readonly UserManager _userManager;

    public UserAccessor(
        UserManager userManager,
        IServiceProvider serviceProvider) : base(serviceProvider)
    {
        _userManager = userManager;
    }

    public Task<IUser> GetUser(ClaimsPrincipal principal)
    {
        var id = _userManager.GetUserId(principal);

        var userId = int.Parse(id);

        return _userManager.Users.Where(x => x.Id == userId)
            .ProjectTo<UserDto>(ProjectionMapping)
            .Cast<IUser>()
            .FirstOrDefaultAsync();
    }
}