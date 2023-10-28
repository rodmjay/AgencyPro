using System.Collections.Generic;
using Newtonsoft.Json;

namespace AgencyPro.Chart.ViewModels
{
    public class ProjectManagerChartOutput : ChartOutput<ProjectManagerChartDataItem>
    {
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<ProjectManagerChartDataItem>>> Re { get; set; }
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<ProjectManagerChartDataItem>>> Pm { get; set; }
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<ProjectManagerChartDataItem>>> Ma { get; set; }

    }
}
