using R6Stats.Stats;
using System.Collections.Generic;

namespace R6Stats.Response.Interfaces
{
    /// <summary>
    /// API response containing seasonal game stats
    /// </summary>
    public interface ISeasonalResponse : IStat
    {
        /// <summary>
        /// Stats for every season, keyed with their respective name
        /// </summary>
        public IReadOnlyDictionary<string, SeasonalStat> SeasonalStats { get; }
    }
}
