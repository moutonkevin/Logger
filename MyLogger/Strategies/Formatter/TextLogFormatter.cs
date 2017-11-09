using System;
using System.Globalization;
using MyLogger.Interfaces;

namespace MyLogger.Strategies.Formatter
{
    internal class TextLogFormatter : ILogFormatter
    {
        private const string TemplateAll = "[{0}] {1} - {2}\n{3}\n";
        private const string TemplateException = "[{0}] {1}: {2}\n";
        private const string TemplateMessage = "[{0}] {1}: {2}\n";

        public string Format(Level level, Exception exp = null, string message = "")
        {
            var time = DateTime.Now.ToString(CultureInfo.InvariantCulture);

            if (exp != null && !string.IsNullOrEmpty(message))
                return string.Format(TemplateAll, time, level, message, exp);
            if (exp != null && string.IsNullOrEmpty(message))
                return string.Format(TemplateException, time, level, exp);
            if (exp == null && !string.IsNullOrEmpty(message))
                return string.Format(TemplateMessage, time, level, message);
            return null;
        }
    }
}