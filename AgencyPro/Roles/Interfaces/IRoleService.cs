using System;
using System.Threading.Tasks;

namespace AgencyPro.Roles.Interfaces
{
    public interface IRoleService<in TCreateInput, in TUpdateInput, TOutput, in TPrincipal>
    {
        Task<T> Create<T>(TCreateInput input) where T : TOutput;
        Task<T> GetById<T>(Guid id) where T : TOutput;
        Task<T> Update<T>(TPrincipal principal, TUpdateInput model) where T : TOutput;
        Task<TOutput> Get(Guid id);
    }
}