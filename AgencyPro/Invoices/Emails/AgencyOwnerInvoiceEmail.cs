﻿using AgencyPro.Email.Interfaces;
using AgencyPro.Invoices.Models;

namespace AgencyPro.Invoices.Emails
{
    public class AgencyOwnerInvoiceEmail : AgencyOwnerProjectInvoiceOutput, IBasicEmail
    {
        public string RecipientName { get; set; }
        public string RecipientEmail { get; set; }
        public string FlowUrl { get; set; }
        public bool SendMail { get; set; }
    }
}