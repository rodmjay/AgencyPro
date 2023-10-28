#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using AgencyPro.Common.Services.Interfaces;
using AgencyPro.Users.Entities;
using Microsoft.AspNetCore.Identity;

namespace AgencyPro.Users.Interfaces;

public interface IRoleService : IService<Role>,
    IRoleStore<Role>,
    IQueryableRoleStore<Role>,
    IRoleClaimStore<Role>
{
}