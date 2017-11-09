using System;
using MyLogger.Interfaces;
using MyLogger.Models.Config;

namespace MyLogger.Strategies.Logger
{
    internal class TextLogger : ILogger
    {
        private readonly ILogConfigReader _config;
        private readonly ILogFormatter _formatter;
        private readonly IWriter _writer;

        public TextLogger(ILogFormatter formatter, IWriter writer, ILogConfigReader config)
        {
            _formatter = formatter;
            _writer = writer;
            _config = config;
        }

        public void LogException(Level level, Exception exception)
        {
            FormatAndWrite(level, exception, null);
        }

        public void LogException(Level level, Exception exception, string message)
        {
            FormatAndWrite(level, exception, message);
        }

        public void LogMessage(Level level, string message)
        {
            FormatAndWrite(level, null, message);
        }

        private void FormatAndWrite(Level level, Exception exception, string message)
        {
            var formattedLog = _formatter.Format(level, exception, message);
            var rules = _config.GetRules(DestinationType.File);

            foreach (var rule in rules)
                _writer.Write(rule.Destination, formattedLog);
        }
    }
}