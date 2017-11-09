using System;

namespace MyLogger.Interfaces
{
    internal interface ILogFormatter
    {
        string Format(Level level, Exception exp = null, string message = "");
    }
}