namespace R6Stats.Stats.Interfaces
{
    /// <summary>
    /// Represents the stats for a game mode type
    /// </summary>
    public interface IGamemodeStat : IGameStat
    {
        /// <summary>
        /// Number of games played in the game mode
        /// </summary>
        int GamesPlayed { get; }

        /// <summary>
        /// Best score achieved in the game mode
        /// </summary>
        int BestScore { get; }
    }
}
