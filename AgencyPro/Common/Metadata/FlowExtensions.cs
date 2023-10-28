using System;
using System.Linq;

namespace AgencyPro.Common.Metadata
{
    public static class FlowExtensions
    {
        public static string GetPath(Type t)
        {
            if (t.GetCustomAttributes(typeof(FlowDirectiveAttribute), true)
                .First() is FlowDirectiveAttribute attr)
            {
                return attr.Path;
            }

            return "";
        }
        public static FlowRoleToken GetRole(Type t)
        {
            if (t.GetCustomAttributes(typeof(FlowDirectiveAttribute), true)
                .First() is FlowDirectiveAttribute attr)
            {
                return attr.Token;
            }

            return FlowRoleToken.None;
        }
    }
}