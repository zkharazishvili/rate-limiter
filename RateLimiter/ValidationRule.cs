using RateLimiter.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RateLimiter
{
    public class ValidationRule
    {
        public ValidationRuleType Type { get; set; }
        public int RequestCount { get; set; }
        public TimeSpan TimeStampForRequests { get; set; }

    }
}
