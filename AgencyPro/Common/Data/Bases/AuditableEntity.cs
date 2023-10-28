#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System;

namespace AgencyPro.Common.Data.Bases;

public abstract class AuditableEntity<T> : BaseEntity<T> where T : class
{
    public virtual DateTimeOffset Created { get; set; }
    public virtual DateTimeOffset Updated { get; set; }
}