using System.Collections.Generic;
using System.Linq;
using MyLogger.Interfaces;
using MyLogger.Models.Config;

namespace MyLogger.Strategies.Config
{
    internal class ConfigFile : ILogConfigReader
    {
        private const string ConfigFilePath = "mylogger.json";
        private readonly IReader _reader;

        public ConfigFile(IReader reader)
        {
            _reader = reader;
        }

        public RuleBaseModel GetRule(string name)
        {
            var config = _reader.Get<ConfigFileModel>(ConfigFilePath);

            return config.Rules.FirstOrDefault(conf => conf.Name.Equals(name));
        }

        public IEnumerable<RuleBaseModel> GetRules()
        {
            var config = _reader.Get<ConfigFileModel>(ConfigFilePath);

            return config.Rules;
        }

        public IEnumerable<RuleBaseModel> GetRules(DestinationType destinationType)
        {
            var config = _reader.Get<ConfigFileModel>(ConfigFilePath);
            var rules = config.Rules.Where(rule => rule.DestinationType == destinationType);

            return rules;
        }
    }
}