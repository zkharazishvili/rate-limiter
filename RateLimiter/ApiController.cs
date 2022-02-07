using System;
using System.Collections.Generic;
using System.Text;

namespace RateLimiter
{
    public class ApiController : RequestHandler
    {

        public List<string> ApiResourceOne(AccessToken token)
        {
            base.ValidateRequest(token);

        }
    }
}
