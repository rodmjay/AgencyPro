using System;
using System.Linq;
using System.Linq.Expressions;
using AgencyPro.Common.Queries;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.TimeEntries.Entities;
using AgencyPro.TimeEntries.Enums;
using AgencyPro.TimeEntries.Models;

namespace AgencyPro.TimeEntries.Extensions
{
    public static class TimeEntryExtensions
    {
        public static IQueryable<TimeEntry> ApplyWhereFilters(this IQueryable<TimeEntry> entities,
            TimeMatrixFilters filters)
        {
            return entities.Where(WhereFilter(filters));
        }

        private static Expression<Func<TimeEntry, bool>> WhereFilter(TimeMatrixFilters filters)
        {
            var expr = PredicateBuilder.True<TimeEntry>();

            if (filters.ContractId.HasValue)
                expr = expr.And(x => x.ContractId == filters.ContractId);

            if (filters.AccountManagerId.HasValue)
                expr = expr.And(x => x.AccountManagerId == filters.AccountManagerId);
            
            if (filters.ContractorId.HasValue)
                expr = expr.And(x => x.ContractorId == filters.ContractorId);
            
            if (filters.CustomerId.HasValue)
                expr = expr.And(x => x.CustomerId == filters.CustomerId);

            if (filters.CustomerOrganizationId.HasValue)
                expr = expr.And(x => x.CustomerOrganizationId == filters.CustomerOrganizationId);

            if (filters.RecruiterId.HasValue)
                expr = expr.And(x => x.RecruiterId == filters.RecruiterId);

            if (filters.RecruiterOrganizationId.HasValue)
                expr = expr.And(x => x.RecruitingOrganizationId == filters.RecruiterOrganizationId);

            if (filters.StartDate.HasValue)
                expr = expr.And(x => x.StartDate >= filters.StartDate);

            if (filters.EndDate.HasValue)
                expr = expr.And(x => x.EndDate <= filters.EndDate);

            if (filters.ProjectManagerId.HasValue)
                expr = expr.And(x => x.ProjectManagerId == filters.ProjectManagerId);

            if (filters.ProviderOrganizationId.HasValue)
                expr = expr.And(x => x.ProviderOrganizationId == filters.ProviderOrganizationId);

            if (filters.StoryId.HasValue)
                expr = expr.And(x => x.StoryId == filters.StoryId);

            if (filters.ApprovalStatus.Any())
                expr = expr.And(x => filters.ApprovalStatus.Contains(x.Status));

            if (filters.TimeType.Any())
                expr = expr.And(x => filters.TimeType.Contains(x.TimeType));

            if(filters.ProjectId.HasValue)
                expr = expr.And(x => x.ProjectId == filters.ProjectId);

            return expr;
        }

        public static IQueryable<TimeEntry> FindById(this IQueryable<TimeEntry> entities, Guid id)
        {
            return entities.Where(x => x.Id == id);
        }

        public static IQueryable<TimeEntry> ForOrganizationMarketer(this IQueryable<TimeEntry> entities,
            IOrganizationMarketer ma)
        {
            return entities.Where(x =>
                x.MarketerId == ma.MarketerId && x.MarketingOrganizationId == ma.OrganizationId);
        }

        public static IQueryable<TimeEntry> ForAgencyOwner(this IQueryable<TimeEntry> entities,
            IAgencyOwner ao)
        {
            return entities.Where(x => x.ProviderOrganizationId == ao.OrganizationId);
        }

        public static IQueryable<TimeEntry> ForOrganizationAccountManager(this IQueryable<TimeEntry> entities,
            IOrganizationAccountManager am)
        {
            return entities.Where(x =>
                x.AccountManagerId == am.AccountManagerId &&
                x.ProviderOrganizationId == am.OrganizationId);
        }

        public static IQueryable<TimeEntry> ForOrganizationProjectManager(this IQueryable<TimeEntry> entities,
            IOrganizationProjectManager pm)
        {
            return entities.Where(x =>
                x.ProjectManagerId == pm.ProjectManagerId &&
                x.ProviderOrganizationId == pm.OrganizationId &&
                x.Status == TimeStatus.Logged);
        }

        public static IQueryable<TimeEntry> ForOrganizationRecruiter(this IQueryable<TimeEntry> entities,
            IOrganizationRecruiter re)
        {
            return entities.Where(
                x => x.RecruiterId == re.RecruiterId &&
                     x.RecruitingOrganizationId == re.OrganizationId);
        }

        public static IQueryable<TimeEntry> ForOrganizationContractor(this IQueryable<TimeEntry> entities,
            IOrganizationContractor co)
        {
            return entities.Where(x =>
                x.ContractorId == co.ContractorId && x.ProviderOrganizationId == co.OrganizationId);
        }

        public static IQueryable<TimeEntry> ForOrganizationCustomer(this IQueryable<TimeEntry> entities,
            IOrganizationCustomer cu)
        {
            return entities.Where(x =>
                x.CustomerId == cu.CustomerId &&
                x.CustomerOrganizationId == cu.OrganizationId);
        }
    }
}