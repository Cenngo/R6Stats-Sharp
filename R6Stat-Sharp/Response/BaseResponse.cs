using Newtonsoft.Json;
using R6Stat_Sharp.Enums;
using R6Stat_Sharp.Models;
using R6Stat_Sharp.Response.Interfaces;
using System;

namespace R6Stat_Sharp.Response
{
    /// <summary>
    /// Base response class for parsing API Responses
    /// </summary>
    public abstract class BaseResponse : IStat, IAlias, IPayload
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; internal set; }

        [JsonProperty("platform")]
        internal string _platform { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public Platform Platform => Enum.Parse<Platform>(_platform, true);

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("ubisoft_id")]
        public string UbisoftID { get; internal set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("uplay_id")]
        public string UplayID { get; internal set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("avatar_url_146")]
        public string Avatar146 { get; internal set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("avatar_url_256")]
        public string Avatar256 { get; internal set; }

        [JsonProperty("last_updated")]
        internal string _lastUpdated { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public DateTime LastUpdated => DateTime.Parse(_lastUpdated);
    }
}
