using System.IO;
using MyLogger.Interfaces;
using Newtonsoft.Json;

namespace MyLogger.Strategies.Reader
{
    internal class FileReader : IReader
    {
        public TOutput Get<TOutput>(string path) where TOutput : class, new()
        {
            var fileContentString = File.ReadAllText(path);
            var config = JsonConvert.DeserializeObject<TOutput>(fileContentString);

            return config;
        }
    }
}