using AgencyPro.Common.Services.Interfaces;
using AgencyPro.Roles.Entities;
using AgencyPro.Roles.ViewModels.Marketers;

namespace AgencyPro.Roles.Interfaces
{
    public interface IMarketerService
        : IService<Marketer>, IRoleService<MarketerInput, MarketerUpdateInput, MarketerOutput, IMarketer>
    {

    }
}