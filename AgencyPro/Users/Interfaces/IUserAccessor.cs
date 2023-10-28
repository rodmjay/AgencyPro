#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Security.Claims;
using System.Threading.Tasks;

namespace AgencyPro.Users.Interfaces;

public interface IUserAccessor
{
    Task<IUser> GetUser(ClaimsPrincipal principal);
}