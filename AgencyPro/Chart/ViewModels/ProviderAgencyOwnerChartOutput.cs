using System.Collections.Generic;
using Newtonsoft.Json;

namespace AgencyPro.Chart.ViewModels
{
    public class ProviderAgencyOwnerChartOutput : ChartOutput<ProviderAgencyOwnerChartDataItem>
    {
        [JsonIgnore]
        public override Dictionary<string, Dictionary<string, List<ProviderAgencyOwnerChartDataItem>>> Re { get; set; }

        [JsonIgnore]
        public override Dictionary<string, Dictionary<string, List<ProviderAgencyOwnerChartDataItem>>> Ma { get; set; }
    }
}
