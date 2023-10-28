using Newtonsoft.Json;

namespace AgencyPro.Chart.ViewModels
{
    public class ProviderAgencyOwnerChartDataItem : ChartDataItem
    {
        [JsonIgnore]
        public override decimal TotalSysStream { get; set; }

        [JsonIgnore]
        public override decimal TotalMaStream { get; set; }

        [JsonIgnore]
        public override decimal TotalReStream { get; set; }

        [JsonIgnore]
        public override decimal TotalRagStream { get; set; }

        [JsonIgnore]
        public override decimal TotalMagStream { get; set; }

        [JsonIgnore]
        public override decimal TotalCuAmount { get; set; }

        public decimal TotalAgencyStream => TotalAgStream;
    }
}