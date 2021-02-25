using Newtonsoft.Json;

namespace R6Stats.Stats
{
    /// <summary>
    /// Represents the stats returned in a <see cref="R6Stats.Response.GenericResponse"/>
    /// </summary>
    public class GenericResponseStats
    {
        [JsonProperty("general")]
        public GeneralStat General { get; private set; }

        [JsonProperty("queue")]
        public GenericQueueStats Queue { get; private set; }

        [JsonProperty("gamemode")]
        public GenericGamemodeStats Gamemode { get; private set; }
    }

    /// <summary>
    /// Object contatining the overall game stats for game queues like "Ranked", "Casual" ...
    /// </summary>
    public class GenericQueueStats
    {
        /// <summary>
        /// Stats for casual queue
        /// </summary>
        [JsonProperty("casual")]
        public QueueStat Casual { get; private set; }

        /// <summary>
        /// Stats for ranked queue
        /// </summary>
        [JsonProperty("ranked")]
        public QueueStat Ranked { get; private set; }

        /// <summary>
        /// Stats for queues other than  ranked and casual
        /// </summary>
        [JsonProperty("other")]
        public QueueStat Other { get; private set; }
    }

    /// <summary>
    /// Object contating the game stats for gamemodes like "Bomb", "Hostage", "Secure Area"
    /// </summary>
    public class GenericGamemodeStats
    {
        /// <summary>
        /// Stats for the gamemode "Bomb"
        /// </summary>
        [JsonProperty("bomb")]
        public BombStats Bomb { get; private set; }

        /// <summary>
        /// Stats for the gamemode "Secure Area"
        /// </summary>
        [JsonProperty("secure_area")]
        public SecureAreaStats SecureArea { get; private set; }

        /// <summary>
        /// Stats for the gamemode "Hostage"
        /// </summary>
        [JsonProperty("hostage")]
        public HostageStats Hostage { get; private set; }
    }
}
