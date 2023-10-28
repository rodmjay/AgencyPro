using System;
using AgencyPro.Common.Metadata;
using Newtonsoft.Json;

namespace AgencyPro.Stories.Models
{
    [FlowDirective(FlowRoleToken.AccountManager, "stories")]
    public class AccountManagerStoryOutput : StoryOutput
    {

        public override Guid ProjectId { get; set; }
        [JsonIgnore] public override DateTimeOffset? AssignedDateTime { get; set; }
        [JsonIgnore] public override DateTimeOffset? ProjectManagerAcceptanceDate { get; set; }
        [JsonIgnore] public override DateTimeOffset? CustomerAcceptanceDate { get; set; }
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;
        public override Guid TargetPersonId => this.AccountManagerId;
    }
}