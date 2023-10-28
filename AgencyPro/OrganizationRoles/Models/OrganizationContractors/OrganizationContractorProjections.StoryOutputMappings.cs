using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Stories.Models;

namespace AgencyPro.OrganizationRoles.Models.OrganizationContractors
{
    public partial class OrganizationContractorProjections
    {
        private void StoryOutputMappings()
        {
            CreateMap<OrganizationContractor, StoryOutput>()
                .ForMember(x => x.ContractorId, x => x.MapFrom(y => y.ContractorId))
                .ForMember(x => x.ContractorName, x => x.MapFrom(y => y.Contractor.Person.DisplayName))
                .ForMember(x => x.ContractorEmail, x => x.MapFrom(y => y.Contractor.Person.User.Email))
                .ForMember(x => x.ContractorPhoneNumber, x => x.MapFrom(y => y.Contractor.Person.User.PhoneNumber))
                .ForMember(x => x.ContractorImageUrl, x => x.MapFrom(y => y.Contractor.Person.ImageUrl));
        }
    }
}