#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using AgencyPro.Common.Data.Enums;
using AgencyPro.Common.Data.Interfaces;
using AgencyPro.Common.Validation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Common.Data.Bases;

public abstract class BaseEntity : ValidatableModel, IObjectState
{
    [NotMapped] [IgnoreDataMember] public ObjectState ObjectState { get; set; }
}

public abstract class BaseEntity<T> : BaseEntity, IEntityTypeConfiguration<T> where T : class
{
    public abstract void Configure(EntityTypeBuilder<T> builder);

    protected void AddAuditProperties(EntityTypeBuilder entity, bool addModifiers = false)
    {
        entity
            .Property<DateTimeOffset>("Created")
            .HasDefaultValueSql("SYSDATETIMEOFFSET()");

        entity
            .Property<DateTimeOffset>("Updated")
            .HasDefaultValueSql("SYSDATETIMEOFFSET()");

        if (!addModifiers) return;

        entity
            .Property<Guid>("CreatedById");

        entity
            .Property<Guid>("UpdatedById");
    }
}