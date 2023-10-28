using System.ComponentModel.DataAnnotations;
using AgencyPro.Organizations.Enums;

namespace AgencyPro.Organizations.Models
{
    public class OrganizationSettingInputModel : OrganizationSettingOutput
    {
        [EnumDataType(typeof(SectionType))]
        public SectionType SectionType { get; set; }
    }
}
