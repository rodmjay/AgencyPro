using Newtonsoft.Json;

namespace AgencyPro.Skills.Models
{
    public class SkillInput
    {
        public virtual string Name { get; set; }

        [JsonIgnore]
        public virtual string IconUrl { get; set; }
        public virtual int Priority { get; set; }
    }
}