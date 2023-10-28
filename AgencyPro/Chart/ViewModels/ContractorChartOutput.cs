using System.Collections.Generic;
using Newtonsoft.Json;

namespace AgencyPro.Chart.ViewModels
{
    public class ContractorChartOutput : ChartOutput<ContractorChartDataItem>
    {
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<ContractorChartDataItem>>> Ma { get; set; }
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<ContractorChartDataItem>>> Re { get; set; }
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<ContractorChartDataItem>>> Am { get; set; }
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<ContractorChartDataItem>>> Pm { get; set; }

    }
}
