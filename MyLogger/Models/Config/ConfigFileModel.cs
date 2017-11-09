using System.Collections.Generic;

namespace MyLogger.Models.Config
{
    internal class ConfigFileModel
    {
        public IEnumerable<RuleModel> Rules { get; set; }
    }
}