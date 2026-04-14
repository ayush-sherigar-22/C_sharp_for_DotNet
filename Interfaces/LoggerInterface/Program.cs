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
}