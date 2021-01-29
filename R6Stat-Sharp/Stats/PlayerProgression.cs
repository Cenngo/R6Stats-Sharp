using Newtonsoft.Json;

namespace R6Stat_Sharp.Stats
{
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
