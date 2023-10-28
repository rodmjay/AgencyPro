using System;
using System.Collections.Generic;
using AgencyPro.Organizations.Enums;
using AgencyPro.Organizations.Models;
using Newtonsoft.Json;

namespace AgencyPro.ProviderOrganizations.Models
{
    /// <summary>
    /// Customer's view of a provider organization
    /// </summary>
    public class CustomerProviderOrganizationOutput : OrganizationOutput
    {
        [JsonIgnore]
        public override OrganizationType OrganizationType { get; set; }

        [JsonIgnore]
        public override DateTimeOffset Updated { get; set; }

        public IDictionary<Guid, int> Skills { get; set; }
    }
}