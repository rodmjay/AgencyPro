﻿#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

namespace AgencyPro.Common.Data.Interfaces;

public interface IMayHaveTenant
{
    /// <summary>TenantId of this entity.</summary>
    int? TenantId { get; set; }
}