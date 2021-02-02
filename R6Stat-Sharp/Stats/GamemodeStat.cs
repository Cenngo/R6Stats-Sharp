using Newtonsoft.Json;
using R6Stats.Stats.Interfaces;
using System;

namespace R6Stats.Stats
{
    /// <summary>
    /// Player stats for a game mode type
    /// </summary>
    public class GamemodeStat : IGamemodeStat
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("best_score")]
        public int BestScore { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("games_played")]
        public int GamesPlayed { get; private set; }

        /// <summary>
        /// Number of games the player lost in this game mode
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("playtime")]
        private long _playTime;

        /// <summary>
        /// Total time spent playing this game mode
        /// </summary>
        public TimeSpan PlayTime => TimeSpan.FromSeconds(_playTime);

        /// <summary>
        /// Number of games the player won in this game mode
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; private set; }

        /// <summary>
        /// Win/Lose ratio of the player for this game mode
        /// </summary>
        [JsonProperty("wl")]
        public double WinLose { get; private set; }
    }
}
