using System;

namespace AgencyPro.Chart.Enums
{
    [Flags]
    public enum ChartBreakdowns : byte 
    {
        None=0,
        PROJ = 1,
        MA = 2,
        RE = 4,
        AM = 8,
        PM = 16,
        CO = 32, //Contractor
        CONT = 64,//Contract
    }
}
