﻿#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using AgencyPro.Common.Data.Enums;
using AgencyPro.Common.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Users.Entities;

public class UserToken : IdentityUserToken<int>, IEntityTypeConfiguration<UserToken>, IObjectState
{
    public User User { get; set; }

    public void Configure(EntityTypeBuilder<UserToken> builder)
    {
        builder.HasKey(x => new
        {
            x.UserId,
            x.LoginProvider,
            x.Name
        });

        builder.HasOne(x => x.User)
            .WithMany(x => x.UserTokens)
            .HasForeignKey(x => x.UserId);
    }

    [NotMapped] [IgnoreDataMember] public ObjectState ObjectState { get; set; }
}