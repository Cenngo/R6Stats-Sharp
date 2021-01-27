using Newtonsoft.Json;
using R6Stat_Sharp.Enums;
using R6Stat_Sharp.Models;
using R6Stat_Sharp.Response.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Response
{
    public abstract class BaseResponse : IResponse, IAlias
    {
        [JsonProperty("username")]
        public string Username { get; internal set; }

        [JsonProperty("platform")]
        internal string _platform { get; set; }

        [JsonIgnore]
        public Platform Platform => Enum.Parse<Platform>(_platform, true);

        [JsonProperty("ubisoft_id")]
        public string UbisoftID { get; internal set; }

        [JsonProperty("uplay_id")]
        public string UplayID { get; internal set; }

        [JsonProperty("avatar_url_146")]
        public string Avatar146 { get; internal set; }

        [JsonProperty("avatar_url_256")]
        public string Avatar256 { get; internal set; }

        [JsonProperty("last_updated")]
        internal string _lastUpdated { get; set; }

        [JsonIgnore]
        public DateTime LastUpdated => DateTime.Parse(_lastUpdated);
    }
}
