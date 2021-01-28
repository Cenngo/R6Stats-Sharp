using Newtonsoft.Json;

namespace R6Stat_Sharp.Stats
{
    public class PlayerProgression
    {
        [JsonProperty("level")]
        public int Level { get; internal set; }

        [JsonProperty("lootbox_probability")]
        public double LootboxProb { get; internal set; }

        [JsonProperty("total_xp")]
        public int TotalXP { get; internal set; }
    }
}
