using System;
using System.Linq;
using System.Linq.Expressions;
using AgencyPro.Candidates.Entities;
using AgencyPro.Candidates.Models;
using AgencyPro.Common.Queries;

namespace AgencyPro.Candidates.Extensions
{
    public static partial class CandidateExtensions
    {
        public static IQueryable<Candidate> FindById(this IQueryable<Candidate> entities, Guid id)
        {
            return entities.Where(x => x.Id == id);
        }

        public static IQueryable<Candidate> ApplyWhereFilters(this IQueryable<Candidate> entities,
            CandidateFilters filters)
        {
            return entities.Where(WhereFilter(filters));
        }

        public static Expression<Func<Candidate, bool>> WhereFilter(CandidateFilters filters)
        {
            var expr = PredicateBuilder.True<Candidate>();

            if (filters.ProjectManagerId.HasValue)
                expr = expr.And(x => x.ProjectManagerId == filters.ProjectManagerId.Value);

            if (filters.ProjectManagerOrganizationId.HasValue)
                expr = expr.And(x => x.ProjectManagerOrganizationId == filters.ProjectManagerOrganizationId.Value);

            return expr;
        }
    }
}