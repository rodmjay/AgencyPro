using System.Collections.Generic;
using Newtonsoft.Json;

namespace AgencyPro.Chart.ViewModels
{
    public class MarketerChartOutput : ChartOutput<MarketerChartDataItem>
    {
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<MarketerChartDataItem>>> Am { get; set; }
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<MarketerChartDataItem>>> Proj { get; set; }
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<MarketerChartDataItem>>> Re { get; set; }
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<MarketerChartDataItem>>> Pm { get; set; }
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<MarketerChartDataItem>>> Ma { get; set; }

    }
}
