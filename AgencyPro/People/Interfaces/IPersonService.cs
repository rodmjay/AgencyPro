using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.People.Entities;
using AgencyPro.People.Models;
using Microsoft.AspNetCore.Http;

namespace AgencyPro.People.Interfaces
{
    public interface IPersonService : IService<Person>
    {
        Task<T> GetPerson<T>(Guid personId) where T : PersonOutput;
        Task<PersonOutput> Get(Guid personId);
        Task<T> GetPerson<T>(string email) where T : PersonOutput;
        Task<bool> SwitchOrgs(SwitchOrganizationInput input);

        Task<List<T>> GetPeople<T>(Guid[] ids) where T : PersonOutput;

        Task<Result> CreatePerson(PersonInput input, Guid? recruiterId, 
            Guid? marketerId, Guid? affiliateOrganizationId, string password = "IdeaFortune!");

        Task<Result> UpdateProfilePic(Guid personId, IFormFile image);
        Task<string> UploadProfilePic(Guid personId, IFormFile image);

        Task<Result> UpdatePersonDetails(Guid personId, PersonDetailsInput input);
        Task<PersonOutput> CreateOrUpdate(PersonOutput person);
    }
}