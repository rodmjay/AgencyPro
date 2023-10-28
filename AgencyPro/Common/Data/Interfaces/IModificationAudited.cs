﻿#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

namespace AgencyPro.Common.Data.Interfaces;

public interface IModificationAudited : IHasModificationTime
{
    /// <summary>Last modifier user for this entity.</summary>
    int? LastModifierUserId { get; set; }
}