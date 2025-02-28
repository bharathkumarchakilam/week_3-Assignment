using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    interface ILogger
    {
        void Log(string message);
    }

    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[FileLogger] {message}");
        }
    }

    class TimestampLogger : ILogger
    {
        private readonly ILogger _logger;

        public TimestampLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.Log($"{DateTime.Now}: {message}");
        }
    }

    class ErrorLogger : ILogger
    {
        private readonly ILogger _logger;

        public ErrorLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.Log($"[ERROR] {message}");
        }
    }

    //class Program17
    //{
    //    static void Main()
    //    {
    //        ILogger logger = new FileLogger();
    //        ILogger timestampLogger = new TimestampLogger(logger);
    //        ILogger errorLogger = new ErrorLogger(timestampLogger);

    //        Console.WriteLine("Basic Logging:");
    //        logger.Log("System started");

    //        Console.WriteLine("\nLogging with Timestamp:");
    //        timestampLogger.Log("System running");

    //        Console.WriteLine("\nLogging with Timestamp and Error Category:");
    //        errorLogger.Log("System crashed");
    //    }
    //}
}
