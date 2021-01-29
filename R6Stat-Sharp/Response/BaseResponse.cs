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
        public string Username { get; private set; }

        [JsonProperty("platform")]
        private string _platform;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public Platform Platform => Enum.Parse<Platform>(_platform, true);

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("ubisoft_id")]
        public string UbisoftID { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("uplay_id")]
        public string UplayID { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("avatar_url_146")]
        public string Avatar146 { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("avatar_url_256")]
        public string Avatar256 { get; private set; }

        [JsonProperty("last_updated")]
        private string _lastUpdated { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public DateTime LastUpdated => DateTime.Parse(_lastUpdated);
    }
}
