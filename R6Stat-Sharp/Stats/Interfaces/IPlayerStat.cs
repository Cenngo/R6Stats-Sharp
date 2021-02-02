namespace R6Stats.Stats.Interfaces
{
    /// <summary>
    /// Represents a players game stats
    /// </summary>
    public interface IPlayerStat
    {
        /// <summary>
        /// Number of kill the player got
        /// </summary>
        int Kills { get; }

        /// <summary>
        /// Number of times the player died
        /// </summary>
        int Deaths { get; }

        /// <summary>
        /// Kill/Death ratio of the player
        /// </summary>
        double KD { get; }

        /// <summary>
        /// Number of games the player won
        /// </summary>
        int Wins { get; }

        /// <summary>
        /// Number of games the player lost
        /// </summary>
        int Losses { get; }

        /// <summary>
        /// Win/Lose ratio of the player
        /// </summary>
        double WinLose { get; }
    }
}
