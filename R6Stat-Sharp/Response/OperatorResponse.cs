using Newtonsoft.Json;
using R6Stats.Response.Interfaces;
using R6Stats.Stats;
using System.Collections.Generic;
using System.Linq;

namespace R6Stats.Response
{
    /// <summary>
    /// Contains operator stats of a player
    /// </summary>
    public class OperatorResponse : BaseResponse, IOperatorResponse
    {
        [JsonProperty("operators")]
        private List<OperatorStat> _operators;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IReadOnlyDictionary<string, OperatorStat> Operators => _operators.ToDictionary(x => x.Name.ToLower().Replace(' ', '_'), x => x);
    }
}
