﻿#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Common.Data.Enums;
using AgencyPro.Common.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Users.Entities;

public class UserRole : IdentityUserRole<int>, IObjectState, IEntityTypeConfiguration<UserRole>
{
    public User User { get; set; }
    public Role Role { get; set; }

    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.HasKey(x => new
        {
            x.UserId,
            x.RoleId
        });

        builder.HasOne(x => x.Role)
            .WithMany(x => x.UserRoles)
            .HasForeignKey(x => x.RoleId);

        builder.HasOne(x => x.User)
            .WithMany(x => x.UserRoles)
            .HasForeignKey(x => x.UserId);
    }

    [NotMapped] public ObjectState ObjectState { get; set; }
}