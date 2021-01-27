using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Response
{
    public class TimeStamps
    {
        [JsonProperty("created")]
        internal string _created;

        [JsonIgnore]
        public DateTime Created => DateTime.Parse(_created);

        [JsonProperty("last_updated")]
        internal string _lastUpdated;

        [JsonIgnore]
        public DateTime LastUpdated => DateTime.Parse(_lastUpdated);
    }
}
