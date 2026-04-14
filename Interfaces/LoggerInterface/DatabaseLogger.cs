namespace LoggerInterface
{
    public class DatabaseLogger : ILogger
    {
        public LogLevel GetLogLevel() => LogLevel.ERROR;

        public void Log(string message)
        {
            Console.WriteLine($"[Database] {message}");
        }


    }
}