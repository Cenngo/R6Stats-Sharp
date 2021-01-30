using Newtonsoft.Json;

namespace R6Stats.Stats
{
    public class HostageStats : GamemodeStat
    {
        [JsonProperty("extractions_denied")]
        public int ExtractionsDenied { get; private set; }
    }
}
