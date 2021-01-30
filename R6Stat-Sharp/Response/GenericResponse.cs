using Newtonsoft.Json;
using R6Stats.Models;
using R6Stats.Response.Interfaces;
using R6Stats.Stats;
using System.Collections.Generic;

namespace R6Stats.Response
{
    /// <summary>
    /// Contains the essential profile data of a user
    /// </summary>
    public class GenericResponse : BaseResponse, IGenericResponse
    {
        [JsonProperty("aliases")]
        private List<Alias> _aliases;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<Alias> Aliases => _aliases;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("progression")]
        public PlayerProgression PlayerProgression { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("stats")]
        public GenericResponseStats Stats { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("timestamps")]
        public TimeStamps TimeStamps { get; private set; }
    }
}
