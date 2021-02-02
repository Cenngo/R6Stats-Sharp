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
        [JsonProperty("level")]
        public int Level { get; private set; }

        [JsonProperty("lootbox_probability")]
        public double LootboxProb { get; private set; }

        [JsonProperty("total_xp")]
        public int TotalXP { get; private set; }
    }
}
