using Newtonsoft.Json;

namespace R6Stats.Stats
{
    /// <summary>
    /// Represents player progression
    /// </summary>
    /// <remarks>
    /// Contains player experience data and alpha pack probability
    /// </remarks>
    public class PlayerProgression
    {
        /// <summary>
        /// Clearance level of the player
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; private set; }

        /// <summary>
        /// Alpha pack drop probability
        /// </summary>
        [JsonProperty("lootbox_probability")]
        public double LootboxProb { get; private set; }

        /// <summary>
        /// Total xp of the player
        /// </summary>
        [JsonProperty("total_xp")]
        public int TotalXP { get; private set; }
    }
}
