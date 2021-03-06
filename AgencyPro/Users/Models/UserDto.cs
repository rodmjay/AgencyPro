﻿#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using AgencyPro.Users.Interfaces;

namespace AgencyPro.Users.Models;

public class UserDto : IUser
{
    public int Id { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }
}