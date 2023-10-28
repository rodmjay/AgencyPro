using System.Collections.Generic;
using Newtonsoft.Json;

namespace AgencyPro.Chart.ViewModels
{
    public class RecruiterChartOutput : ChartOutput<RecruiterChartDataItem>
    {
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<RecruiterChartDataItem>>> Proj { get; set; }
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<RecruiterChartDataItem>>> Re { get; set; }
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<RecruiterChartDataItem>>> Pm { get; set; }
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<RecruiterChartDataItem>>> Ma { get; set; }

    }
}
