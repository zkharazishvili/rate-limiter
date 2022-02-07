using System;
using System.Collections.Generic;
using System.Text;

namespace RateLimiter
{
    public class ApiServiceResponse<T>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public string? ErrorCode { get; set; }
        public T? Data { get; set; }
    }
}
