using System;

namespace AgencyPro.Common.Metadata
{
    
    public class FlowDirectiveAttribute : Attribute
    {
        public FlowRoleToken Token { get; }
        public string Path { get; }

        public FlowDirectiveAttribute(FlowRoleToken token, string path)
        {
            Token = token;
            Path = path;
        }
    }
}