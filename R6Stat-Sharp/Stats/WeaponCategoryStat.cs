using Newtonsoft.Json;
using R6Stats.Models;
using R6Stats.Stats.Interfaces;

namespace R6Stats.Stats
{
    /// <summary>
    /// Weapon stats for a weapon category
    /// </summary>
    public class WeaponCategoryStat : TimeStamps, IWeaponStat
    {
        /// <summary>
        /// Weapon category
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; private set; }

        /// <summary>
        /// Total number of kills scored while using a weapon from this weapon category
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; private set; }

        /// <summary>
        /// Total number of times the player died while using a weapon from this weapon category
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        /// <summary>
        /// Ratio of <see cref="Kills"/> to <see cref="Deaths"/>
        /// </summary>
        [JsonProperty("kd")]
        public double KD { get; private set; }

        /// <summary>
        /// Total number of headshot kills scored while using a weapon from this weapon category
        /// </summary>
        [JsonProperty("headshots")]
        public int HeadShots { get; private set; }

        /// <summary>
        /// Ratio of <see cref="HeadShots"/> to the <see cref="Kills"/>
        /// </summary>
        [JsonProperty("headshot_percentage")]
        public double HSPercentage { get; private set; }

        /// <summary>
        /// Number of times a weapon from this weapon category is equipped
        /// </summary>
        [JsonProperty("times_chosen")]
        public int TimesChosen { get; private set; }

        /// <summary>
        /// Total number of bullets fired from guns belonging to this weapon category
        /// </summary>
        [JsonProperty("bullets_fired")]
        public int BulletsFired { get; private set; }

        /// <summary>
        /// Number of bullets that hit an enemy which is fired from guns belonging to this weapon category
        /// </summary>
        [JsonProperty("bullets_hit")]
        public int BulletsHit { get; private set; }
    }
}
