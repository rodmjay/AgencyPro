#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using AgencyPro.Common.Data.Contexts;
using Microsoft.EntityFrameworkCore.Design;

namespace AgencyPro.Common.Data.Interfaces;

public interface IApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
{
}