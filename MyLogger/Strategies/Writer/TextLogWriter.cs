using System.IO;
using System.Text;
using MyLogger.Interfaces;

namespace MyLogger.Strategies.Writer
{
    internal class TextLogWriter : IWriter
    {
        public void Write<TDestination, TContent>(TDestination destination, TContent log)
        {
            using (var fs = new FileStream(destination as string, FileMode.Append, FileAccess.Write))
            {
                if (fs.CanWrite)
                {
                    var logBytes = Encoding.ASCII.GetBytes(log as string);
                    fs.Write(logBytes, 0, logBytes.Length);
                }
            }
        }
    }
}