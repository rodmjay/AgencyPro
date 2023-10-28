using System;
using System.Linq;
using AgencyPro.Proposals.Entities;

namespace AgencyPro.Proposals.Extensions
{
    public static partial class ProposalExtensions
    {
        public static IQueryable<T> FindById<T>(this IQueryable<T> entities, Guid id)
        where T : FixedPriceProposal
        {
            return entities.Where(x => x.Id == id);
        }
    }
}