using AgencyPro.Common.Metadata;
using AgencyPro.Email.Interfaces;
using AgencyPro.Orders.Models;

namespace AgencyPro.Orders.Emails
{
    [FlowDirective(FlowRoleToken.Customer, "work-orders/buyer-work-orders")]
    public class CustomerWorkOrderEmail : BuyerWorkOrderOutput, IBasicEmail
    {
        public string RecipientName { get; set; }
        public string RecipientEmail { get; set; }
        public string FlowUrl { get; set; }
        public bool SendMail { get; set; }
    }
}