using Newtonsoft.Json;
using R6Stat_Sharp.Response;

namespace R6Stat_Sharp.Stats
{
    public class LeaderboardSlot : BaseResponse
    {
        [JsonProperty("stats")]
        public LeaderboardUserStats Stats { get; internal set; }

        [JsonProperty("score")]
        public double Score { get; internal set; }

        [JsonProperty("position")]
        public int Position { get; internal set; }
    }

    public class LeaderboardUserStats
    {
        [JsonProperty("level")]
        public int Level { get; internal set; }

        [JsonProperty("kd")]
        public double KD { get; internal set; }

        [JsonProperty("wl")]
        public double WL { get; internal set; }
    }
}
