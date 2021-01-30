using Newtonsoft.Json;
using R6Stats.Response.Interfaces;
using R6Stats.Stats;
using System.Collections.Generic;

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
        public IReadOnlyList<OperatorStat> Operators => _operators;
    }
}
