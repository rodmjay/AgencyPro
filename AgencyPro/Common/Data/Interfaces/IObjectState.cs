#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using AgencyPro.Common.Data.Enums;

namespace AgencyPro.Common.Data.Interfaces;

public interface IObjectState
{
    public ObjectState ObjectState { get; set; }
}