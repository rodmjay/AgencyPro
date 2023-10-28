using System;

namespace AgencyPro.Roles.ViewModels.Recruiters
{
    public class RecruiterInput : RecruiterUpdateInput
    {
        public Guid PersonId { get; set; }
    }
}