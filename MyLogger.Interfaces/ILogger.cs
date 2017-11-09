using System;

namespace MyLogger.Interfaces
{
    public enum Level
    {
        Info,
        Error
    }

    public interface ILogger
    {
        void LogMessage(Level level, string message);
        void LogException(Level level, Exception exception);
        void LogException(Level level, Exception exception, string message);
    }
}