using System;
using System.Collections.Generic;
using System.Linq;

namespace AgencyPro.Common.Extensions
{
    public static class StatisticsExtensions
    {
        // https://stackoverflow.com/questions/2714639/calculating-weighted-average-with-linq
        // double weightedAverage = records.WeightedAverage(x => x.Value, x => x.Length);
        public static decimal WeightedAverage<T>(this IEnumerable<T> records, Func<T, decimal> value,
            Func<T, decimal> weight)
        {
            if (!records.Any())
                return 0;

            var weightedValueSum = records.Sum(x => value(x) * weight(x));
            var weightSum = records.Sum(x => weight(x));

            if (weightSum != 0)
                return weightedValueSum / weightSum;
            throw new DivideByZeroException("Your message here");
        }
    }
}