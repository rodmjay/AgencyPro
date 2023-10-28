using System.Collections.Generic;
using Newtonsoft.Json;

namespace AgencyPro.Chart.ViewModels
{
    public class CustomerChartOutput : ChartOutput<CustomerChartDataItem>
    {
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<CustomerChartDataItem>>> Re { get; set; }
        [JsonIgnore] public override Dictionary<string, Dictionary<string, List<CustomerChartDataItem>>> Ma { get; set; }

    }
}
