using Newtonsoft.Json;
using R6Stat_Sharp.Response;

namespace R6Stat_Sharp.Stats
{
    public class LeaderboardSlot : BaseResponse
    {
        [JsonProperty("stats")]
        public LeaderboardUserStats Stats { get; private set; }

        [JsonProperty("score")]
        public double Score { get; private set; }

        [JsonProperty("position")]
        public int Position { get; private set; }
    }

    public class LeaderboardUserStats
    {
        [JsonProperty("level")]
        public int Level { get; private set; }

        [JsonProperty("kd")]
        public double KD { get; private set; }

        [JsonProperty("wl")]
        public double WL { get; private set; }
    }
}
