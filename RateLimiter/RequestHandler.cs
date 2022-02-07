using System;
using System.Collections.Generic;
using System.Text;

namespace RateLimiter
{
    public class RequestHandler<T>
    {
        protected bool ValidateRequest(AccessToken token)
        {

            return true;
        }

        protected ApiServiceResponse<T> HandleRequest()
        {
            return new ApiServiceResponse<T>() { Data = default, Success = true };
        }
    }
}
