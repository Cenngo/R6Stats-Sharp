using R6Stat_Sharp.Stats;
using System.Collections.Generic;

namespace R6Stat_Sharp.Response
{
    /// <summary>
    /// API response containing seasonal game stats
    /// </summary>
    public interface ISeasonalResponse
    {
        /// <summary>
        /// Stats for every season, keyed with their respective name
        /// </summary>
        public IReadOnlyDictionary<string, SeasonalStat> SeasonalStats { get; }
    }
}
