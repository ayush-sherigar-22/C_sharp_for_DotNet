namespace LoggerInterface
{
    public class ConsoleLogger : ILogger
    {
        public LogLevel GetLogLevel() => LogLevel.INFO;

        public void Log(string message)
        {
            Console.WriteLine($"[Console] {message}");
        }
    }
}