using Newtonsoft.Json;

namespace R6Stats.Stats
{
    /// <summary>
    /// Represents stats for a game weapon
    /// </summary>
    public class WeaponStat : WeaponCategoryStat
    {
        /// <summary>
        /// Name of the weapon
        /// </summary>
        [JsonProperty("weapon")]
        public string Weapon { get; private set; }
    }
}
