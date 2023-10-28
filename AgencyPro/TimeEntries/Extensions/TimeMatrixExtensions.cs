using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AgencyPro.Common.Queries;
using AgencyPro.TimeEntries.Entities;
using AgencyPro.TimeEntries.Interfaces;
using AgencyPro.TimeEntries.Models;

namespace AgencyPro.TimeEntries.Extensions
{
    public static class TimeMatrixExtensions
    {
        public static Tuple<DateTime[], decimal[], StreamBreakdown[]> StreamsByDay(this IEnumerable<ITimeMatrix> entities)
        {
            var dic = entities.GroupBy(x => x.Date.Date)
                .ToDictionary(x => x.Key, g => g.ToList());

            var arrayOfDays = dic.Keys.ToArray();

            var hoursArray = dic.Values.Select(x => x.Sum(y => y.Hours))
                .ToArray();

            var moneyArray = dic.Values.Select(x => new StreamBreakdown()
            {
                RecruiterStream = x.Sum(y => y.TotalRecruiterStream),
                AgencyStream = x.Sum(y => y.TotalAgencyStream),
                RecruitingAgencyStream = x.Sum(y => y.TotalRecruitingAgencyStream),
                MarketingAgencyStream = x.Sum(y => y.TotalMarketingAgencyStream),
                MarketerStream = x.Sum(y => y.TotalMarketerStream),
                ProjectManagerStream = x.Sum(y => y.TotalProjectManagerStream),
                AccountManagerStream = x.Sum(y => y.TotalAccountManagerStream),
                ContractorStream = x.Sum(y => y.TotalContractorStream),
                SystemStream = x.Sum(y => y.TotalSystemStream),
            }).ToArray();

            return new Tuple<DateTime[], decimal[], StreamBreakdown[]>(arrayOfDays, hoursArray, moneyArray);
        }

        public static IQueryable<TimeMatrix> ApplyWhereFilters(this IQueryable<TimeMatrix> entities,
           TimeMatrixFilters filters)
        {
            return entities.Where(WhereFilter(filters));
        }

        private static Expression<Func<TimeMatrix, bool>> WhereFilter(TimeMatrixFilters filters)
        {
            var expr = PredicateBuilder.True<TimeMatrix>();

            if (filters.ContractId.HasValue)
                expr = expr.And(x => x.ContractId == filters.ContractId);

            if (filters.ProjectId.HasValue)
                expr = expr.And(x => x.ProjectId == filters.ProjectId);

            if (filters.AccountManagerId.HasValue)
                expr = expr.And(x => x.AccountManagerId == filters.AccountManagerId);

            if (filters.ProviderOrganizationId.HasValue)
                expr = expr.And(x =>
                    x.ProviderOrganizationId== filters.ProviderOrganizationId);

            if (filters.ContractorId.HasValue)
                expr = expr.And(x => x.ContractorId == filters.ContractorId);
            
            if (filters.CustomerId.HasValue)
                expr = expr.And(x => x.CustomerId == filters.CustomerId);

            if (filters.CustomerOrganizationId.HasValue)
                expr = expr.And(x => x.CustomerOrganizationId == filters.CustomerOrganizationId);

            if (filters.RecruiterId.HasValue)
                expr = expr.And(x => x.RecruiterId == filters.RecruiterId);

            if (filters.RecruiterOrganizationId.HasValue)
                expr = expr.And(x => x.RecruiterOrganizationId == filters.RecruiterOrganizationId);

            if (filters.MarketerId.HasValue)
                expr = expr.And(x => x.MarketerId == filters.MarketerId);

            if (filters.MarketerOrganizationId.HasValue)
                expr = expr.And(x => x.MarketerOrganizationId == filters.MarketerOrganizationId);

            if (filters.StartDate.HasValue)
                expr = expr.And(x => x.Date >= filters.StartDate);

            if (filters.EndDate.HasValue)
                expr = expr.And(x => x.Date < filters.EndDate);

            if (filters.ProjectManagerId.HasValue)
                expr = expr.And(x => x.ProjectManagerId == filters.ProjectManagerId);
            
            return expr;
        }


    }
}