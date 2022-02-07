using System;
using System.Collections.Generic;
using System.Text;

namespace RateLimiter.Attributes
{
    public class ResourceInfoAttribute : Attribute
    {
        public ResourceInfoAttribute(string Name)
        {
            ResourceName = Name;
        }
        public string ResourceName { get; set; }
    }
}
