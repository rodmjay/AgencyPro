using AgencyPro.Leads.Entities;
using AgencyPro.Leads.Models;
using AutoMapper;

namespace AgencyPro.Leads.Projections
{
    public class LeadMatrixProjectionMap : Profile
    {
        public LeadMatrixProjectionMap()
        {
            CreateMap<LeadMatrix, LeadMatrixOutput>()
                .IncludeAllDerived();

            CreateMap<LeadMatrix, AgencyOwnerLeadMatrixOutput>();
            CreateMap<LeadMatrix, MarketerLeadMatrixOutput>();
        }
    }
}