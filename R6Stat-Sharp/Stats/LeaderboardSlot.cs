using Newtonsoft.Json;
using R6Stats.Response;

namespace R6Stats.Stats
{
    /// <summary>
    /// Represents a slot of a <see cref="Leaderboard"/>
    /// </summary>
    public class LeaderboardSlot : BaseResponse
    {
        /// <summary>
        /// Stats for the player in this <see cref="LeaderboardSlot"/>
        /// </summary>
        [JsonProperty("stats")]
        public LeaderboardUserStats Stats { get; private set; }

        /// <summary>
        /// Leaderboard score of a player
        /// </summary>
        [JsonProperty("score")]
        public double Score { get; private set; }

        /// <summary>
        /// Position of this slot in the leaderboard
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; private set; }
    }

    /// <summary>
    /// User stats for a player in a leaderboard
    /// </summary>
    public class LeaderboardUserStats
    {
        /// <summary>
        /// Level of the player
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; private set; }

        /// <summary>
        /// Kill/Death ratio of the player
        /// </summary>
        [JsonProperty("kd")]
        public double KD { get; private set; }

        /// <summary>
        /// Win/Lose ratio of the player
        /// </summary>
        [JsonProperty("wl")]
        public double WL { get; private set; }
    }
}
