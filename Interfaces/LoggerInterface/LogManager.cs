namespace LoggerInterface
{
    public class LogManager

    {
        private List<ILogger> _logger;

        public LogManager(List<ILogger> logger)
        {
            if (logger == null || logger.Count == 0)
            {
                throw new ArgumentNullException("List Cant be null");
            }
            _logger = logger;


        }

        public void LogMessage(string message, LogLevel level)
        {
            foreach (var logger in _logger)
            {
                if (level >= logger.GetLogLevel())
                {
                    logger.Log(message);
                }
            }
        }

        public void Log(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Message cannot be empty");
            }

        }
    }
}