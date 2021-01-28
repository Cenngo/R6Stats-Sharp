using Newtonsoft.Json;
using R6Stat_Sharp.Stats;
using System.Collections.Generic;

namespace R6Stat_Sharp.Response
{
    /// <summary>
    /// Contains operator stats of a player
    /// </summary>
    public class OperatorResponse : BaseResponse, IOperatorResponse
    {
        [JsonProperty("operators")]
        internal List<OperatorStat> _operators;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IReadOnlyList<OperatorStat> Operators => _operators;
    }
}
