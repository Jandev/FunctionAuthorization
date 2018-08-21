using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace FunctionsWithAuthentication
{
    public static class UserLevel
    {
        [FunctionName("UserLevel")]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.User, "get", Route = null)]
            HttpRequestMessage req,
            ILogger logger)
        {
            var hello = new Hello(logger);
            var message = hello.World(nameof(UserLevel));

            return req.CreateResponse(HttpStatusCode.OK, message);
        }
    }
}