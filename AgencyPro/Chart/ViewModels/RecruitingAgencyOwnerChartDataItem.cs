﻿using Newtonsoft.Json;

namespace AgencyPro.Chart.ViewModels
{
    public class RecruitingAgencyOwnerChartDataItem : ChartDataItem
    {
        [JsonIgnore]
        public override decimal TotalSysStream { get; set; }

        [JsonIgnore]
        public override decimal TotalMaStream { get; set; }
        
        [JsonIgnore]
        public override decimal TotalPmStream { get; set; }

        [JsonIgnore]
        public override decimal TotalAmStream { get; set; }

        [JsonIgnore]
        public override decimal TotalAgStream { get; set; }
        
        [JsonIgnore]
        public override decimal TotalMagStream { get; set; }

        [JsonIgnore]
        public override decimal TotalCoStream { get; set; }

        [JsonIgnore]
        public override decimal TotalCuAmount { get; set; }
    }
}