using Newtonsoft.Json;

namespace R6Stats.Stats
{
    /// <summary>
    /// Game stats for the game mode "Hostage"
    /// </summary>
    public class HostageStats : GamemodeStat
    {
        /// <summary>
        /// Number of times the hostage extraction was prevented
        /// </summary>
        [JsonProperty("extractions_denied")]
        public int ExtractionsDenied { get; private set; }
    }
}
