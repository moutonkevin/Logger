using System.Collections.Generic;
using MyLogger.Models.Config;

namespace MyLogger.Interfaces
{
    internal interface ILogConfigReader
    {
        RuleBaseModel GetRule(string name);
        IEnumerable<RuleBaseModel> GetRules();
        IEnumerable<RuleBaseModel> GetRules(DestinationType destinationType);
    }
}