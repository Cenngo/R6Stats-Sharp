using Newtonsoft.Json;
using R6Stats.Models;
using R6Stats.Stats.Interfaces;

namespace R6Stats.Stats
{
    public class WeaponCategoryStat : TimeStamps, IWeaponStat
    {
        [JsonProperty("category")]
        public string Category { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("kd")]
        public double KD { get; private set; }

        [JsonProperty("headshots")]
        public int HeadShots { get; private set; }

        [JsonProperty("headshot_percentage")]
        public double HSPercentage { get; private set; }

        [JsonProperty("times_chosen")]
        public int TimesChosen { get; private set; }

        [JsonProperty("bullets_fired")]
        public int BulletsFired { get; private set; }

        [JsonProperty("bullets_hit")]
        public int BulletsHit { get; private set; }
    }
}
