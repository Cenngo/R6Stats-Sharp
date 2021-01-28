using Newtonsoft.Json;

namespace R6Stat_Sharp.Stats
{
    public class HostageStats : GamemodeStat
    {
        [JsonProperty("extractions_denied")]
        public int ExtractionsDenied { get; internal set; }
    }
}
