using AgencyPro.Organizations.Entities;
using AgencyPro.Organizations.Models;
using AutoMapper;

namespace AgencyPro.Organizations.Projections
{
    public partial class OrganizationSettingProjections : Profile
    {
        public OrganizationSettingProjections()
        {
            CreateMap<OrganizationSetting, OrganizationSettingViewModel>();
        }
    }
}
