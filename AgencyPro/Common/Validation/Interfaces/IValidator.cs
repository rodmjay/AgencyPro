#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.ComponentModel.DataAnnotations;
using AgencyPro.Common.Data.Interfaces;
using AgencyPro.Common.Services.Interfaces;

namespace AgencyPro.Common.Validation.Interfaces;

public interface IValidator<T> where T : class, IObjectState
{
    ValidationResult Validate(IService<T> service, T account, string value);
}