using Autofac;
using MyLogger.Interfaces;

namespace MyLogger
{
    public class LogManager
    {
        private static readonly object _lock = new object();
        private static ILogger _currentLogger { get; set; }

        public static ILogger CurrentLogger
        {
            get
            {
                lock (_lock)
                {
                    if (_currentLogger == null)
                        _currentLogger = Ioc.Container.Resolve<ILogger>();
                    return _currentLogger;
                }
            }
            set
            {
                lock (_lock)
                {
                    _currentLogger = value;
                }
            }
        }
    }
}