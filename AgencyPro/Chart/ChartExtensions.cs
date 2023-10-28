using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AgencyPro.Chart.Enums;
using AgencyPro.Chart.ViewModels;
using AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers;
using AgencyPro.OrganizationRoles.Models.OrganizationContractors;
using AgencyPro.OrganizationRoles.Models.OrganizationMarketers;
using AgencyPro.OrganizationRoles.Models.OrganizationProjectManagers;
using AgencyPro.OrganizationRoles.Models.OrganizationRecruiters;
using AgencyPro.Projects.Models;
using AgencyPro.TimeEntries.Models;
using AgencyPro.TimeEntries.Models.TimeMatrix;

namespace AgencyPro.Chart
{
    public static class ChartExtensions
    {
        public static List<T> ToStatusData<M, T>(this ICollection<M> matrix)
         where M : TimeMatrixOutput
            where T : ChartDataItem, new()
        {
            return matrix.GroupBy(p => new { p.Date.DayOfYear, p.TimeStatus }, (key, group) => ToChartDataItem<T>(group, group.FirstOrDefault()?.TimeStatus.ToString())).
                   ToList();
        }

        public static List<T> ToProjData<M, P, T>(this ICollection<M> matrix, ICollection<P> projects)
         where M : TimeMatrixOutput
         where P : ProjectOutput
        where T : ChartDataItem, new()
        {
            return matrix.GroupBy(p => new { p.Date.DayOfYear, p.ProjectId }, (key, group) => ToChartDataItem<T>(group)).
                   Select(x => { x.Name = projects.FirstOrDefault(y => y.Id == x.ProjectId)?.Name; return x; }).
                   ToList();
        }
        public static List<T> ToAmData<M, P, T>(this ICollection<M> matrix, ICollection<P> accountManagers)
        where M : TimeMatrixOutput
        where P : OrganizationAccountManagerOutput
        where T : ChartDataItem, new()
        {
            return matrix.GroupBy(p => new { p.Date.DayOfYear, p.AccountManagerId }, (key, group) => ToChartDataItem<T>(group)).
                   Select(x => { x.Name = accountManagers.FirstOrDefault(y => y.AccountManagerId == x.AccountManagerId)?.DisplayName; return x; }).
                   ToList();
        }


        public static List<T> ToPmData<M, P, T>(this ICollection<M> matrix, ICollection<P> projectManagers)
        where M : TimeMatrixOutput
        where P : OrganizationProjectManagerOutput
        where T : ChartDataItem, new()
        {
            return matrix.GroupBy(p => new { p.Date.DayOfYear, p.ProjectManagerId }, (key, group) => ToChartDataItem<T>(group)).
                   Select(x => { x.Name = projectManagers.FirstOrDefault(y => y.ProjectManagerId == x.ProjectManagerId)?.DisplayName; return x; }).
                   ToList();
        }


        public static List<T> ToMaData<M, P, T>(this ICollection<M> matrix, ICollection<P> marketers)
        where M : TimeMatrixOutput
        where P : OrganizationMarketerOutput
        where T : ChartDataItem, new()
        {
            return matrix.GroupBy(p => new { p.Date.DayOfYear, p.MarketerId }, (key, group) => ToChartDataItem<T>(group)).
                   Select(x => { x.Name = marketers.FirstOrDefault(y => y.MarketerId == x.MarketerId)?.DisplayName; return x; }).
                   ToList();
        }

        public static List<T> ToReData<M, P, T>(this ICollection<M> matrix, ICollection<P> recruiters)
        where M : TimeMatrixOutput
        where P : OrganizationRecruiterOutput
        where T : ChartDataItem, new()
        {
            return matrix.GroupBy(p => new { p.Date.DayOfYear, p.RecruiterId }, (key, group) => ToChartDataItem<T>(group)).
                   Select(x => { x.Name = recruiters.FirstOrDefault(y => y.RecruiterId == x.RecruiterId)?.DisplayName; return x; }).
                   ToList();
        }


        public static List<T> ToCoData<M, P, T>(this ICollection<M> matrix, ICollection<P> contractors)
        where M : TimeMatrixOutput
        where P : OrganizationContractorOutput
        where T : ChartDataItem, new()
        {
            var result = matrix.GroupBy(p => new { p.Date.DayOfYear, p.ContractorId }, (key, group) => ToChartDataItem<T>(group)).
                   Select(x => { x.Name = contractors.FirstOrDefault(y => y.ContractorId == x.ContractorId)?.DisplayName; return x; }).
                   ToList();
            return result;
        }

        private static int WeekSinceDate(DateTime date)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan ts = date - epoch;

            CultureInfo culture = System.Threading.Thread.CurrentThread.CurrentCulture;
    

            
            return Convert.ToInt32(Math.Round(ts.TotalDays / 7, 0, MidpointRounding.AwayFromZero));
        }

        public static IEnumerable<IGrouping<string, T>> TopLevelGrouping<T>(this IEnumerable<T> dailyData, DateBreakdown dateBreakdown)
            where T : ChartDataItem
        {
            var currentWeek = WeekNumberSince2019(DateTime.Now);
            var currenMonth = DateTime.Today.Month;
            return dateBreakdown == DateBreakdown.ByWeek ? dailyData.OrderByDescending(x => x.Date).GroupBy(matrix => $"w{currentWeek - WeekNumberSince2019(matrix.Date)}") :
                                                                             dailyData.OrderByDescending(x => x.Date).GroupBy(matrix => $"m{currenMonth - matrix.Date.Month}");
        }

        public static Dictionary<string, Dictionary<string, List<T>>> SecondLevelGrouping<T>(this IEnumerable<IGrouping<string, T>> topLevelGroup, DateBreakdown dateBreakdown)
        where T : ChartDataItem
        {
            CultureInfo culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var returnValue = topLevelGroup.ToDictionary(g => g.Key, g => g.OrderBy(x => x.Date).GroupBy(weeklyDataItem => weeklyDataItem.Date.DayOfYear).
                                    ToDictionary(j => dateBreakdown == DateBreakdown.ByWeek ?
                                                                    culture.DateTimeFormat.GetAbbreviatedDayName(j.First().Date.DayOfWeek) + "_" + j.First().Date.Day :
                                                                    $"d{j.First().Date.Day}",
                                                  j => j.Where(q => q.Dummy != true).ToList()
                                ));

            return returnValue;

        }

        public static DateTime FirstDayOfWeek(this DateTime date)
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = date.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;

            if (diff < 0)
            {
                diff += 7;
            }

            return date.AddDays(-diff).Date;
        }

        public static DateTime LastDayOfWeek(this DateTime date)
        {
            return date.FirstDayOfWeek().AddDays(6);
        }

        public static DateTime LastDayOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1).AddMonths(1).AddDays(-1);
        }

        public static int WeekNumberSince2019(DateTime date)
        {
            CultureInfo culture = System.Threading.Thread.CurrentThread.CurrentCulture;

            var currentWeek = culture.Calendar.GetWeekOfYear(date, culture.DateTimeFormat.CalendarWeekRule, culture.DateTimeFormat.FirstDayOfWeek);

            if (date.Year == 2020)
                currentWeek += 52;

            return currentWeek;
        }

        private static T ToChartDataItem<T>(IEnumerable<TimeMatrixOutput> group, string name = "NA")
        where T : ChartDataItem, new()
        {
            var timeMatrixOutputs = group.ToList();
            return new T
            {
                Name = name,
                Date = timeMatrixOutputs.First().Date,
                RecruiterId = timeMatrixOutputs.First().RecruiterId,
                MarketerId = timeMatrixOutputs.First().MarketerId,
                ProjectId = timeMatrixOutputs.First().ProjectId,
                AccountManagerId = timeMatrixOutputs.First().AccountManagerId,
                ProjectManagerId = timeMatrixOutputs.First().ProjectManagerId,
                ContractId = timeMatrixOutputs.First().ContractId,
                ContractorId = timeMatrixOutputs.First().ContractorId,
                Hours = timeMatrixOutputs.Sum(x => x.Hours),
                TotalSysStream = timeMatrixOutputs.Sum(x => x.TotalSystemStream),
                TotalCuAmount = timeMatrixOutputs.Sum(x => x.TotalCustomerAmount),
                TotalReStream = timeMatrixOutputs.Sum(x => x.TotalRecruiterStream),
                TotalMaStream = timeMatrixOutputs.Sum(x => x.TotalMarketerStream),
                TotalAgStream = timeMatrixOutputs.Sum(x => x.TotalAgencyStream),
                TotalMagStream = timeMatrixOutputs.Sum(x => x.TotalMarketingAgencyStream),
                TotalRagStream = timeMatrixOutputs.Sum(x => x.TotalRecruitingAgencyStream),
                TotalCoStream = timeMatrixOutputs.Sum(x => x.TotalContractorStream),
                TotalPmStream = timeMatrixOutputs.Sum(x => x.TotalProjectManagerStream),
                TotalAmStream = timeMatrixOutputs.Sum(x => x.TotalAccountManagerStream),
                TimeStatus = timeMatrixOutputs.First().TimeStatus
            };
        }
        public static IEnumerable<T> FillMissingDays<T>(this List<T> data, DateBreakdown dateBreakdown, TimeMatrixFilters filters)
        where T : ChartDataItem, new()
        {
            var startDate = DateTime.Now;
            var endDate = DateTime.Now;
            if (dateBreakdown == DateBreakdown.ByMonth)
            {
                endDate = DateTime.Today.LastDayOfMonth();
                startDate = endDate.AddMonths(-3).AddDays(1);
            }
            else
            {
                endDate = DateTime.Today.LastDayOfWeek();
                startDate = endDate.AddDays(-20);
            }
            startDate = filters.StartDate ?? startDate;
            //endDate = filters.EndDate?? endDate;
            for (var day = startDate; day <= endDate; day = day.AddDays(1))
            {
                if (data.All(x => x.Date.Date != day.Date))
                {
                    data.Add(new T
                    {
                        Date = day,
                        Dummy = true
                    });
                }
            }
            return data.Where(x => x.Date <= endDate && x.Date >= startDate);
        }
    }
}
