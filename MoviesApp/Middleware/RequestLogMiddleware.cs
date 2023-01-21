using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace MoviesApp.Middleware
{
    public class RequestLogMiddleware
    {
        private readonly RequestDelegate _next;
       

        public RequestLogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, ILogger<RequestLogMiddleware> logger)
        {
            string req = httpContext.Request.Path;
            bool hasTom = req.Contains("/Actors");
            if (hasTom)
            {
                logger.LogInformation($"Request: {httpContext.Request.Path}/{httpContext.Request.Body}/{httpContext.Request.Headers}  Method: {httpContext.Request.Method}");
            }

            await _next(httpContext);
        }
    }
}