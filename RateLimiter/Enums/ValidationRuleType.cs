using System;
using System.Collections.Generic;
using System.Text;

namespace RateLimiter.Enums
{
    public enum ValidationRuleType
    {
        X_REQUEST_PER_TIMESTAMP,
        TIMESTAMP_FROM_LAST_REQUEST
    }
}
