using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNoteTaking.Repository
{
    internal static class Logging
    {
        public static ILog ConfigureLogging(Type type)
        {
            var layout = new PatternLayout
            {
                ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
            };
            layout.ActivateOptions();

            var consoleAppender = new ConsoleAppender
            {
                Layout = layout,
                Threshold = Level.Info
            };

            var errorFileLogger = new FileAppender
            {
                File = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "error.log"),
                AppendToFile = true,
                Layout = layout,
                Threshold = Level.Error
            };

            BasicConfigurator.Configure(consoleAppender, errorFileLogger);
            var logger = LogManager.GetLogger(type);
            logger.Info("Logging configured");
            return logger;
        }
    }
}
