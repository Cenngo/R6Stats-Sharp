using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Stats
{
    public class GenericResponseStats
    {
        [JsonProperty("general")]
        public GeneralStat General { get; internal set; }

        [JsonProperty("queue")]
        public GenericQueueStats Queue { get; internal set; }

        [JsonProperty("gamemode")]
        public GenericGamemodeStats Gamemode { get; internal set; }
    }

    public class GenericQueueStats
    {
        [JsonProperty("casual")]
        public QueueStat Casual { get; internal set; }

        [JsonProperty("ranked")]
        public QueueStat Ranked { get; internal set; }

        [JsonProperty("other")]
        public QueueStat Other { get; internal set; }
    }

    public class GenericGamemodeStats
    {
        [JsonProperty("bomb")]
        public BombStats Bomb { get; internal set; }

        [JsonProperty("secure_area")]
        public SecureAreaStats SecureArea { get; internal set; }

        [JsonProperty("hostage")]
        public HostageStats Hostage { get; internal set; }
    }
}
