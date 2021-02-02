using Newtonsoft.Json;

namespace R6Stats.Stats
{

    public class GenericResponseStats
    {
        [JsonProperty("general")]
        public GeneralStat General { get; private set; }

        [JsonProperty("queue")]
        public GenericQueueStats Queue { get; private set; }

        [JsonProperty("gamemode")]
        public GenericGamemodeStats Gamemode { get; private set; }
    }

    public class GenericQueueStats
    {
        [JsonProperty("casual")]
        public QueueStat Casual { get; private set; }

        [JsonProperty("ranked")]
        public QueueStat Ranked { get; private set; }

        [JsonProperty("other")]
        public QueueStat Other { get; private set; }
    }

    public class GenericGamemodeStats
    {
        [JsonProperty("bomb")]
        public BombStats Bomb { get; private set; }

        [JsonProperty("secure_area")]
        public SecureAreaStats SecureArea { get; private set; }

        [JsonProperty("hostage")]
        public HostageStats Hostage { get; private set; }
    }
}
