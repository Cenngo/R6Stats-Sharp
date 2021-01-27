using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp
{
    public class R6StatsClientConfig
    {
        public string ApiKey { get; }

        public R6StatsClientConfig(string APIKey )
        {
            ApiKey = APIKey;
        }
    }
}
