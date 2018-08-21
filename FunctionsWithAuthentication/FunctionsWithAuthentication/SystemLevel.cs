using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace FunctionsWithAuthentication
{
    public static class SystemLevel
    {
        [FunctionName("SystemLevel")]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.System, "get", Route = null)]
            HttpRequestMessage req,
            ILogger logger)
        {
            var hello = new Hello(logger);
            var message = hello.World(nameof(SystemLevel));

            return req.CreateResponse(HttpStatusCode.OK, message);
        }
    }
}