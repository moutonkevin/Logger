using System;
using MyLogger.Interfaces;

namespace MyLogger.Console
{
    public class Program
    {
        private static void Main()
        {
            var logger = LogManager.CurrentLogger;

            logger.LogException(Level.Info, new InvalidOperationException("oops"), "test");
        }
    }
}