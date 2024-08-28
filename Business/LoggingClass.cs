using Microsoft.Extensions.Logging;
namespace LoggingOptimizely.Business
{
    public class LoggingClass:ILoggingClass
    {
        private readonly ILogger<LoggingClass> _logger;

        public LoggingClass(ILogger<LoggingClass> logger)
        {
            _logger = logger;
        }

        public string LogSomething(string message)
        {
            _logger.LogInformation(message);
            return message;
        }
    }
}
