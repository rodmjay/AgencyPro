using System.IO;

namespace AgencyPro.Messaging.Email
{
    public class EmailAttachment
    {
        public string Name { get; set; }

        public MemoryStream File { get; set; }
    }
}