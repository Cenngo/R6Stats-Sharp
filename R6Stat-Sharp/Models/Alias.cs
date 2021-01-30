using Newtonsoft.Json;
using R6Stats.Response.Interfaces;
using System;

namespace R6Stats.Models
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public class Alias : IAlias
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; private set; }

        [JsonProperty("last_seen_at")]
        private string _lastSeenAt;

        /// <summary>
        /// The last use date for the given alias
        /// </summary>
        [JsonIgnore]
        public DateTime LastSeenAt => DateTime.Parse(_lastSeenAt);
    }
}
