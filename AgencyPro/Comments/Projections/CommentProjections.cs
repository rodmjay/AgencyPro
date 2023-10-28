using AgencyPro.Comments.Entities;
using AgencyPro.Comments.Models;
using AutoMapper;

namespace AgencyPro.Comments.Projections
{
    class CommentProjections : Profile
    {
        public CommentProjections()
        {
            CreateMap<Comment, CommentOutput>()
                .ForMember(x=>x.PersonName, opt=>opt.MapFrom(x=>x.Creator.Person.DisplayName))
                .ForMember(x=>x.PersonId, opt=>opt.MapFrom(x=>x.CreatedById))
                .ForMember(x=>x.PersonImageUrl, opt=>opt.MapFrom(x=>x.Creator.Person.ImageUrl))
                .ForMember(x=>x.OrganizationName, opt=>opt.MapFrom(x=>x.Creator.Organization.Name))
                .ForMember(x=>x.OrganizationImageUrl, opt=>opt.MapFrom(x=>x.Creator.Organization.ImageUrl))
                .ForMember(x=>x.OrganizationId, opt=>opt.MapFrom(x=>x.OrganizationId))
                .ForMember(x=>x.Created, opt=>opt.MapFrom(x=>x.Created))
                .ForMember(x => x.Body, opt => opt.MapFrom(x => x.Body));
        }
    }
}
