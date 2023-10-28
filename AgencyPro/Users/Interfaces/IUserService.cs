﻿#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using AgencyPro.Common.Services.Interfaces;
using AgencyPro.Users.Entities;
using Microsoft.AspNetCore.Identity;

namespace AgencyPro.Users.Interfaces;

public interface IUserService : IService<User>,
    IQueryableUserStore<User>,
    IUserPasswordStore<User>,
    IUserRoleStore<User>,
    IUserClaimStore<User>,
    IUserLoginStore<User>,
    IUserLockoutStore<User>,
    IUserPhoneNumberStore<User>,
    IUserEmailStore<User>,
    IUserAuthenticatorKeyStore<User>,
    IUserTwoFactorStore<User>,
    IUserTwoFactorRecoveryCodeStore<User>,
    IUserSecurityStampStore<User>,
    IUserAuthenticationTokenStore<User>
{
}