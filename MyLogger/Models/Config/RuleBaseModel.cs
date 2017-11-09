using MyLogger.Interfaces;

namespace MyLogger.Models.Config
{
    internal enum DestinationType
    {
        File,
        Api
    }

    internal class RuleBaseModel
    {
        public string Name { get; set; }
        public DestinationType DestinationType { get; set; }
        public string Destination { get; set; }
        public Level MinimumLevelForLogging { get; set; }
    }
}