using System.Collections.Generic;
using AgencyPro.Transfers.Models;

namespace AgencyPro.FinancialAccounts.Models
{
    public class FinancialAccountDetails : FinancialAccountOutput
    {
        public ICollection<TransferOutput> Transfers { get; set; } 
    }
}