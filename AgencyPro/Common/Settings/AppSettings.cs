#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using AgencyPro.Common.Caching;
using AgencyPro.Common.Data;
using AgencyPro.Email.Settings;

namespace AgencyPro.Common.Settings;

public class AppSettings
{
    public string ApiUrl { get; set; }
    public string JsClientUrl { get; set; }
    public string MvcClientUrl { get; set; }
    public string Name { get; set; }
    public string Authority { get; set; }
    public string Audience { get; set; }
    public AppBaseUrls Urls { get; set; }

    public DatabaseSettings Database { get; set; }
    public CacheSettings Cache { get; set; }
    public SendGridSettings SendGrid { get; set; }
    public string CodeSigningThumbprint { get; set; }

    public string IdentityEndpoint => ApiUrl + "/v1.0/identity";
}