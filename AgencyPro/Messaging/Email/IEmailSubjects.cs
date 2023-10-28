using System.Collections.Generic;

namespace AgencyPro.Messaging.Email
{
    public interface IEmailSubjects : IDictionary<string, Dictionary<string, string>>
    {
    }
}