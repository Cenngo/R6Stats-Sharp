using Newtonsoft.Json;
using R6Stats.Stats.Interfaces;
using System;

namespace R6Stats.Stats
{
    /// <summary>
    /// Game stats for a game queue
    /// </summary>
    public class QueueStat : IGenericStat
    {
        /// <summary>
        /// Number of times the player died
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        /// <summary>
        /// Number of times the player traded kills with an opponent
        /// </summary>
        [JsonProperty("draws")]
        public int Draws { get; private set; }

        /// <summary>
        /// Number of games played
        /// </summary>
        [JsonProperty("games_played")]
        public int GamesPlayed { get; private set; }

        /// <summary>
        /// Kill/Death ratio achieved by the player in this game queue
        /// </summary>
        [JsonProperty("kd")]
        public double KD { get; private set; }

        /// <summary>
        /// Number of kills scored by the player in this game queue
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; private set; }

        /// <summary>
        /// Number of games lost in this game queue
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("playtime")]
        private int _playTime;

        /// <summary>
        /// Total times spent playing this game queue
        /// </summary>
        [JsonIgnore]
        public TimeSpan PlayTime => TimeSpan.FromSeconds(_playTime);

        /// <summary>
        /// Number of games the player won in this game queue
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; private set; }

        /// <summary>
        /// Win/Lose ratio of the player
        /// </summary>
        [JsonProperty("wl")]
        public double WinLose { get; private set; }
    }
}
