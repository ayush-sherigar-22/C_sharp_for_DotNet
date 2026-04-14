namespace LoggerInterface
{
    public class FileLogger : ILogger
    {
        public LogLevel GetLogLevel() => LogLevel.WARNING;

        public void Log(string message)
        {
            Console.WriteLine($"[File] {message}");
        }
    }
}