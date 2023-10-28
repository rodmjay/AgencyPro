using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AgencyPro.Organizations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SectionType : byte
    {
        AccountManager = 1,
        ProjectManager
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MenuType : byte
    {
        Project = 1,
        Contract,
        Story
    }
}
