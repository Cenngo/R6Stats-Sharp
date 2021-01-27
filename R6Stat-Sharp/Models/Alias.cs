using Newtonsoft.Json;
using R6Stat_Sharp.Response.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Models
{
    public class Alias : IAlias
    {
        [JsonProperty("username")]
        public string Username { get; internal set; }

        [JsonProperty("last_seen_at")]
        internal string _lastSeenAt;

        [JsonIgnore]
        public DateTime LastSeenAt => DateTime.Parse(_lastSeenAt);
    }
}
