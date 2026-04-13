using System;
using System.Threading.Channels;

namespace LoggerInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var loggers = new List<ILogger>
        {
            new ConsoleLogger(),
            new FileLogger(),
            new DatabaseLogger()
        };

            var manager = new LogManager(loggers);

            manager.LogMessage("User logged in", LogLevel.INFO);
            Console.WriteLine("----");
            manager.LogMessage("System warning", LogLevel.WARNING);
            Console.WriteLine("----");
            manager.LogMessage("Crash occurred", LogLevel.ERROR);
        }
    }

    public interface ILogger
    {
        void Log(string message);
        LogLevel GetLogLevel();
    }

    public enum LogLevel
    {
        INFO,
        WARNING,
        ERROR
    };


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

    public class ConsoleLogger : ILogger
    {
        public LogLevel GetLogLevel() => LogLevel.INFO;

        public void Log(string message)
        {
            Console.WriteLine($"[Console] {message}");
        }
    }

    public class FileLogger : ILogger
    {
        public LogLevel GetLogLevel() => LogLevel.WARNING;

        public void Log(string message)
        {
            Console.WriteLine($"[File] {message}");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public LogLevel GetLogLevel() => LogLevel.ERROR;

        public void Log(string message)
        {
            Console.WriteLine($"[Database] {message}");
        }


    }
}