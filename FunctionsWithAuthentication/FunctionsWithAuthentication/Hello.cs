using System;
using Microsoft.Extensions.Logging;

namespace FunctionsWithAuthentication
{
    internal class Hello
    {
        private readonly ILogger logger;

        public Hello(ILogger logger)
        {
            this.logger = logger;
        }

        public string World(string caller)
        {
            var message = $"Hello from `{caller}`.";
            this.logger.LogInformation(message);
            return message;
        }
    }
}