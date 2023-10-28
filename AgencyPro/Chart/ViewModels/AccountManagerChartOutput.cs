using System.Collections.Generic;
using Newtonsoft.Json;

namespace AgencyPro.Chart.ViewModels
{
    public class AccountManagerChartOutput : ChartOutput<AccountManagerChartDataItem>
    {
       [JsonIgnore] public override Dictionary<string, Dictionary<string, List<AccountManagerChartDataItem>>> Am { get; set; }

       [JsonIgnore]
       public override Dictionary<string, Dictionary<string, List<AccountManagerChartDataItem>>> Ma { get; set; }
    }
}
