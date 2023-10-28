namespace AgencyPro.People.Models
{
    public class RemovePersonInput
    {
        public bool RemoveContractor { get; set; }
        public bool RemoveProjectManager { get; set; }
        public bool RemoveAccountManager { get; set; }
        public bool RemoveMarketer { get; set; }
        public bool RemoveRecruiter { get; set; }
    }
}