using Newtonsoft.Json;
using R6Stat_Sharp.Models;
using R6Stat_Sharp.Response.Interfaces;
using R6Stat_Sharp.Stats;
using System.Collections.Generic;

namespace R6Stat_Sharp.Response
{
    /// <summary>
    /// Contains the essential profile data of a user
    /// </summary>
    public class GenericResponse : BaseResponse, IGenericResponse
    {
        [JsonProperty("aliases")]
        internal List<Alias> _aliases;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<Alias> Aliases => _aliases;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("progression")]
        public PlayerProgression PlayerProgression { get; internal set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("stats")]
        public GenericResponseStats Stats { get; internal set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("timestamps")]
        public TimeStamps TimeStamps { get; internal set; }
    }
}
