using R6Stats.Models;
using R6Stats.Stats;
using System.Collections.Generic;

namespace R6Stats.Response.Interfaces
{
    /// <summary>
    /// API response containing the essential information about a player
    /// </summary>
    public interface IGenericResponse : IStat
    {
        /// <summary>
        /// Previous aliases used by the player
        /// </summary>
        IReadOnlyList<Alias> Aliases { get; }

        /// <summary>
        /// Player's experience data
        /// </summary>
        PlayerProgression PlayerProgression { get; }

        /// <summary>
        /// Overall stats of the player
        /// </summary>
        GenericResponseStats Stats { get; }

        /// <summary>
        /// Time information of the archived data
        /// </summary>
        TimeStamps TimeStamps { get; }
    }
}
