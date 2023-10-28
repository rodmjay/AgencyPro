#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using AgencyPro.Users.Entities;
using AgencyPro.Users.Models;
using AutoMapper;

namespace AgencyPro.Users.Projections;

public class UserProjections : Profile
{
    public UserProjections()
    {
        CreateMap<User, UserDto>()
            .IncludeAllDerived();
    }
}