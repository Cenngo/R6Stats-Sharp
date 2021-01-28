using Newtonsoft.Json;
using R6Stat_Sharp.Response;

namespace R6Stat_Sharp.Stats
{
    public class WeaponCategoryStat : TimeStamps, IWeaponStat
    {
        [JsonProperty("category")]
        public string Category { get; internal set; }

        [JsonProperty("kills")]
        public int Kills { get; internal set; }

        [JsonProperty("deaths")]
        public int Deaths { get; internal set; }

        [JsonProperty("kd")]
        public double KD { get; internal set; }

        [JsonProperty("headshots")]
        public int HeadShots { get; internal set; }

        [JsonProperty("headshot_percentage")]
        public double HSPercentage { get; internal set; }

        [JsonProperty("times_chosen")]
        public int TimesChosen { get; internal set; }

        [JsonProperty("bullets_fired")]
        public int BulletsFired { get; internal set; }

        [JsonProperty("bullets_hit")]
        public int BulletsHit { get; internal set; }
    }
}
