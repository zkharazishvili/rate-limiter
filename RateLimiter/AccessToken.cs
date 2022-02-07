using System;
using System.Collections.Generic;
using System.Text;

namespace RateLimiter
{
    public class AccessToken
    {
        public decimal LifeTime { get; set; }
        public int ClientId { get; set; }
        public DateTime DateCreated => DateTime.Now;
    }
}
