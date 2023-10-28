using System;
using System.Collections.Generic;
using AgencyPro.Contracts.Enums;

namespace AgencyPro.Contracts.Models
{
    public class MarketerContractDetailsOutput : MarketerContractOutput
    {
        public Dictionary<DateTimeOffset, ContractStatus> StatusTransitions { get; set; }
    }
}