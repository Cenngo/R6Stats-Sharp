using Newtonsoft.Json;
using System;

namespace R6Stat_Sharp.Stats
{
    public class GeneralStat : IGenericStat, IPlayerStat
    {
        [JsonProperty("assists")]
        public int Assists { get; internal set; }

        [JsonProperty("barricades_deployed")]
        public int BarricadesDeployed { get; internal set; }

        [JsonProperty("blind_kills")]
        public int BlindKills { get; internal set; }

        [JsonProperty("bullets_fired")]
        public int BulletsFired { get; internal set; }

        [JsonProperty("bullets_hit")]
        public int BulletsHit { get; internal set; }

        [JsonProperty("dbnos")]
        public int DBNOs { get; internal set; }

        [JsonProperty("distance_travelled")]
        public long DistanceTravelled { get; internal set; }

        [JsonProperty("gadgets_destroyed")]
        public int GadgetsDestroyed { get; internal set; }

        [JsonProperty("headshots")]
        public int HeadShots { get; internal set; }

        [JsonProperty("melee_kills")]
        public int MeleeKills { get; internal set; }

        [JsonProperty("penetration_kills")]
        public int PenetrationKills { get; internal set; }

        [JsonProperty("rappel_breaches")]
        public int RappelBreaches { get; internal set; }

        [JsonProperty("reinforcements_deployed")]
        public int ReinforcementsDeployed { get; internal set; }

        [JsonProperty("revives")]
        public int Revives { get; internal set; }

        [JsonProperty("suicides")]
        public int Suicides { get; internal set; }

        [JsonProperty("deaths")]
        public int Deaths { get; internal set; }

        [JsonProperty("draws")]
        public int Draws { get; internal set; }

        [JsonProperty("games_played")]
        public int GamesPlayed { get; internal set; }

        [JsonProperty("kd")]
        public double KD { get; internal set; }

        [JsonProperty("kills")]
        public int Kills { get; internal set; }

        [JsonProperty("losses")]
        public int Losses { get; internal set; }

        [JsonProperty("playtime")]
        internal long _playTime;

        [JsonIgnore]
        public TimeSpan PlayTime => TimeSpan.FromSeconds(_playTime);

        [JsonProperty("wins")]
        public int Wins { get; internal set; }

        [JsonProperty("wl")]
        public double WinLose { get; internal set; }
    }
}
