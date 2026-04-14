namespace LoggerInterface
{
    public interface ILogger
    {
        void Log(string message);
        LogLevel GetLogLevel();
    }
}