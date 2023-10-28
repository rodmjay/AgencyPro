using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace AgencyPro.OrganizationPeople.Models
{
    public class OrganizationPeopleMetadata
    {
        public OrganizationPeopleMetadata()
        {
            CustomerIds = new List<Guid>();
            ContractorIds = new List<Guid>();
            RecruiterIds = new List<Guid>();
            AccountManagerIds = new List<Guid>();
            ProjectManagerIds = new List<Guid>();
            MarketerIds = new List<Guid>();
        }

        [JsonProperty("customers")] public ICollection<Guid> CustomerIds { get; set; }

        [JsonProperty("contractors")] public ICollection<Guid> ContractorIds { get; set; }

        [JsonProperty("recruiters")] public ICollection<Guid> RecruiterIds { get; set; }

        [JsonProperty("accountManagers")] public ICollection<Guid> AccountManagerIds { get; set; }

        [JsonProperty("projectManagers")] public ICollection<Guid> ProjectManagerIds { get; set; }

        [JsonProperty("marketers")] public ICollection<Guid> MarketerIds { get; set; }

        [JsonIgnore]
        public ICollection<Guid> PeopleIds
        {
            get
            {
                var list = new List<Guid>();

                list.AddRange(CustomerIds);
                list.AddRange(ContractorIds);
                list.AddRange(RecruiterIds);
                list.AddRange(AccountManagerIds);
                list.AddRange(ProjectManagerIds);
                list.AddRange(MarketerIds);

                return list.Distinct().ToList();
            }
        }
    }
}