using Newtonsoft.Json;
using System;

namespace R6Stat_Sharp.Response
{
    /// <summary>
    /// Represents a timestamp for an operation
    /// </summary>
    public class TimeStamps
    {
        [JsonProperty("created")]
        private string _created;

        /// <summary>
        /// Date the object was created
        /// </summary>
        [JsonIgnore]
        public DateTime Created => DateTime.Parse(_created);

        [JsonProperty("last_updated")]
        private string _lastUpdated;

        /// <summary>
        /// Date the object was last updated
        /// </summary>
        [JsonIgnore]
        public DateTime LastUpdated => DateTime.Parse(_lastUpdated);
    }
}
