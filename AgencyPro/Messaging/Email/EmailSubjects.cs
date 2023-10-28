using System.Collections.Generic;

namespace AgencyPro.Messaging.Email
{
    public class EmailSubjects
    {
        public EmailSubjects(Dictionary<string, Dictionary<string, string>> subjects = null)
        {
            Subjects = subjects ?? new Dictionary<string, Dictionary<string, string>>();
        }

        public Dictionary<string, Dictionary<string, string>> Subjects { get; set; }
    }
}