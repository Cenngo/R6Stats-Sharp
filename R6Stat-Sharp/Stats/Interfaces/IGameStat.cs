using System;

namespace R6Stats.Stats.Interfaces
{
    /// <summary>
    /// Represents the general game stats
    /// </summary>
    public interface IGameStat
    {
        /// <summary>
        /// Number of times the player lost the game
        /// </summary>
        int Losses { get; }

        /// <summary>
        /// Total time spent playing
        /// </summary>
        TimeSpan PlayTime { get; }

        /// <summary>
        /// Number of times the player won the game
        /// </summary>
        int Wins { get; }

        /// <summary>
        /// Win/Lose ratio
        /// </summary>
        double WinLose { get; }
    }
}
