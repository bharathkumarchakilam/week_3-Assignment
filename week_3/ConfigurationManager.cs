using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    class ConfigurationManager
    {
        private static ConfigurationManager _instance = new ConfigurationManager();
        public string ConfigValue = "Default Config";

        private ConfigurationManager() { }

        public static ConfigurationManager GetInstance()
        {
            return _instance;
        }
    }

    //class Program18
    //{
    //    static void Main()
    //    {
    //        ConfigurationManager config1 = ConfigurationManager.GetInstance();
    //        Console.WriteLine("Config: " + config1.ConfigValue);

    //        ConfigurationManager config2 = ConfigurationManager.GetInstance();
    //        config2.ConfigValue = "New Config";

    //        Console.WriteLine("Updated Config: " + config1.ConfigValue);
    //        Console.WriteLine("Are both the same? " + (config1 == config2));
    //    }
    //}
}
