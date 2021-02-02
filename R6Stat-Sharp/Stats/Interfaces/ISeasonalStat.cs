using System;
using System.Collections.Generic;

namespace R6Stats.Stats.Interfaces
{
    /// <summary>
    /// Represents the stats for a season
    /// </summary>
    public interface ISeasonalStat
    {
        /// <summary>
        /// Start date of the season
        /// </summary>
        DateTime StartDate { get; }

        /// <summary>
        /// End date of the season
        /// </summary>
        DateTime EndDate { get; }

        /// <summary>
        /// Season stats with respect to the server regions
        /// </summary>
        IReadOnlyList<RegionStat> Regions { get; }
    }
}
