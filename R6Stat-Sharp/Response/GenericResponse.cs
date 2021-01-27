using Newtonsoft.Json;
using R6Stat_Sharp.Models;
using R6Stat_Sharp.Response.Interfaces;
using R6Stat_Sharp.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Response
{
    public class GenericResponse : BaseResponse, IGenericResponse
    {
        [JsonProperty("aliases")]
        internal List<Alias> _aliases;

        [JsonIgnore]
        public IReadOnlyList<Alias> Aliases => _aliases;

        [JsonProperty("progression")]
        public PlayerProgression PlayerProgression { get; internal set; }

        [JsonProperty("stats")]
        public GenericResponseStats Stats { get; internal set; }

        [JsonProperty("timestamps")]
        public TimeStamps TimeStamps { get; internal set; }
    }
}
