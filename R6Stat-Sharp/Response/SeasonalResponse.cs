using Newtonsoft.Json;
using R6Stats.Response.Interfaces;
using R6Stats.Stats;
using R6Stats.Stats.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace R6Stats.Response
{
    /// <summary>
    /// Contains game stats of a player for each season
    /// </summary>
    public class SeasonalResponse : BaseResponse, ISeasonalResponse
    {
        [JsonProperty("seasons")]
        private Dictionary<string, SeasonalStat> _seasonalStats;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public IReadOnlyDictionary<string, SeasonalStat> SeasonalStats => _seasonalStats;

        public IRankedData CurrentRankedData => _seasonalStats.Values.ElementAt(0).Regions.ElementAt(0);
    }
}
