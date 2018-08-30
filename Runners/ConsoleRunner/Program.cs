using Microsoft.Extensions.Logging;
using System;

namespace ConsoleRunner
{
    class Program
    {
        private static readonly ILoggerFactory _consoleLoggerFactory = new LoggerFactory().AddConsole();
        private static readonly ILogger _uiLogger = _consoleLoggerFactory.CreateLogger("UI");

        static void Main(string[] args)
        {
            DisplayHeaderText(_uiLogger);
            Console.ReadLine();
        }

        private static void DisplayHeaderText(ILogger logger)
        {
            logger.LogInformation(@"__________________    _________");
            logger.LogInformation(@"\______   \______ \  /   _____/");
            logger.LogInformation(@" |    |  _/|    |  \ \_____  \ ");
            logger.LogInformation(@" |    |   \|    `   \/        \");
            logger.LogInformation(@" |______  /_______  /_______  /");
            logger.LogInformation(@"        \/        \/        \/ ");
            logger.LogInformation("===== Build Dependency Scanner =====");
        }
    }
}