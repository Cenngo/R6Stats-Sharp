using R6Stat_Sharp.Enums;
using System;

namespace R6Stat_Sharp.Models
{
    /// <summary>
    /// Represents an API response from the R6Stats <see cref="https://r6stats.com/"/> API
    /// </summary>
    public interface IResponse
    {
        /// <summary>
        /// Username of the searched player
        /// </summary>
        string Username { get; }

        /// <summary>
        /// Preferred platform by the user
        /// </summary>
        Platform Platform { get; }
        /// <summary>
        /// Ubisoft ID string of the user
        /// </summary>
        string UbisoftID { get; }
        /// <summary>
        /// Uplay ID string of the user
        /// </summary>
        string UplayID { get; }
        /// <summary>
        /// Url of players 146px avatar  picture
        /// </summary>
        string Avatar146 { get; }
        /// <summary>
        /// Url of players 256px avatar  picture
        /// </summary>
        string Avatar256 { get; }
        /// <summary>
        /// Time the parsed data was last updated at
        /// </summary>
        DateTime LastUpdated { get; }
    }
}
