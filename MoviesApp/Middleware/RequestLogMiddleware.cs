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
            bool request = req.Contains("/Actors");
            if (request)
            {
                logger.LogInformation(
                    $"Request: {httpContext.Request.Path}/{httpContext.Request.ContentLength}/{httpContext.Request.Cookies}/ {httpContext.Request.Body}/{httpContext.Request.IsHttps}/{httpContext.Request.Scheme}  Method: {httpContext.Request.Method}");
            }

            await _next(httpContext);
        }
    }
}