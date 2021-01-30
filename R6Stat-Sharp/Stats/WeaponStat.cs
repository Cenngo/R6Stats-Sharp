using Newtonsoft.Json;

namespace R6Stats.Stats
{
    public class WeaponStat : WeaponCategoryStat
    {
        [JsonProperty("weapon")]
        public string Weapon { get; private set; }
    }
}
