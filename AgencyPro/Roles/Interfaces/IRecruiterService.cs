using AgencyPro.Common.Services.Interfaces;
using AgencyPro.Roles.Entities;
using AgencyPro.Roles.ViewModels.Recruiters;

namespace AgencyPro.Roles.Interfaces
{
    public interface IRecruiterService : IService<Recruiter>, IRoleService<RecruiterInput, RecruiterUpdateInput, RecruiterOutput, IRecruiter>
    {
    }
}