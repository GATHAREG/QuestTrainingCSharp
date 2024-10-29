using log4net.Config;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using System.IO;
using Serilog;
using Serilog.Events;

namespace Logging
{
    internal class Program
    {
        //private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        

        static void Main(string[] args)
        {
            // Set up a simple configuration that logs on the console.
            //BasicConfigurator.Configure();
            //ConfigureLogging();

            var logger = new LoggerConfiguration()
               .WriteTo.Console(
            restrictedToMinimumLevel: LogEventLevel.Information,
            outputTemplate: "[{Timestamp} {Level:u3}] {Message}{NewLine}")
                .CreateLogger();


            logger.Information("Application started");

            try
            {
                Console.Write("Enter num1: ");
                int i = int.Parse(Console.ReadLine());
                Console.Write("Enter num2: ");
                int j = int.Parse(Console.ReadLine());
                int sum = i + j;
                Console.WriteLine(sum);
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
            }
        }
        //private static void ConfigureLogging()
        //{
        //    var repository = LogManager.GetRepository();
        //    var layout = new PatternLayout
        //    {
        //        ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
        //    };
        //    layout.ActivateOptions();

        //    var consoleAppender = new ConsoleAppender
        //    {
        //        Layout = layout,
        //        Threshold = Level.Info
        //    };

        //    var errorFileLogger = new FileAppender
        //    {
        //        File = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "error.log"),
        //        AppendToFile = true,
        //        Layout = layout,
        //        Threshold = Level.Error,
        //    };

        //    BasicConfigurator.Configure(repository, consoleAppender, errorFileLogger);
        //}

    }
}
