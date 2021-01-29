using Newtonsoft.Json;
using R6Stat_Sharp.Models;
using R6Stat_Sharp.Stats;
using System.Collections.Generic;
using System.Linq;

namespace R6Stat_Sharp.Response
{
    /// <summary>
    /// Contains game stats of a player for each season
    /// </summary>
    public class SeasonalResponse : BaseResponse, ISeasonalResponse
    {
        [JsonProperty("seasons")]
        internal Dictionary<string, SeasonalStat> _seasonalStats;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public IReadOnlyDictionary<string, SeasonalStat> SeasonalStats => _seasonalStats;

        public SeasonalStat CurrentRankedData => _seasonalStats.Values.ElementAt(0);
    }
}
