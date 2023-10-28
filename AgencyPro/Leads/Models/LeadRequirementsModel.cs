using System;

namespace AgencyPro.Leads.Models
{
    public class LeadRequirementsModel
    {
        public string Idea { get; set; }
        public string Summary { get; set; }
        public Guid[] Skills { get; set; }
    }
}