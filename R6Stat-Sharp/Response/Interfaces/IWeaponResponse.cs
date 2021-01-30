using R6Stats.Stats;
using System.Collections.Generic;

namespace R6Stats.Response.Interfaces
{
    /// <summary>
    /// API response containing statistics for each weapon used by a player
    /// </summary>
    public interface IWeaponResponse : IStat
    {
        /// <summary>
        /// Collection of stats for different weapons
        /// </summary>
        IReadOnlyList<WeaponStat> Weapons { get; }
    }
}
