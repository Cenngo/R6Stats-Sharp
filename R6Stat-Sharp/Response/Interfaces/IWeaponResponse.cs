using R6Stat_Sharp.Models;
using R6Stat_Sharp.Stats;
using System.Collections.Generic;

namespace R6Stat_Sharp.Response
{
    /// <summary>
    /// API response containing statistics for each weapon used by a player
    /// </summary>
    public interface IWeaponResponse : IResponse
    {
        /// <summary>
        /// Collection of stats for different weapons
        /// </summary>
        IReadOnlyList<WeaponStat> Weapons { get; }
    }
}
