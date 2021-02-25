namespace R6Stats.Stats.Interfaces
{
    /// <summary>
    /// Represents a player's generic stats
    /// </summary>
    public interface IGenericStat : IGameStat
    {
        /// <summary>
        /// Number of games played by the player
        /// </summary>
        int GamesPlayed { get; }

        /// <summary>
        /// The number of times the player died
        /// </summary>
        int Deaths { get; }

        /// <summary>
        /// Number of times the player traded a kill with an opponent
        /// </summary>
        int Draws { get; }

        /// <summary>
        /// Kill/Death ratio of the player
        /// </summary>
        double KD { get; }

        /// <summary>
        /// Number of times the player kill an opponent
        /// </summary>
        int Kills { get; }
    }
}
