using Newtonsoft.Json;

namespace R6Stat_Sharp.Stats
{
    public class WeaponStat : WeaponCategoryStat
    {
        [JsonProperty("weapon")]
        public string Weapon { get; internal set; }
    }
}
