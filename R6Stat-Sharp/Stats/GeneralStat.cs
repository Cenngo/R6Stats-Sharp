using Newtonsoft.Json;
using R6Stats.Stats.Interfaces;
using System;

namespace R6Stats.Stats
{
    public class GeneralStat : IGenericStat, IPlayerStat
    {
        [JsonProperty("assists")]
        public int Assists { get; private set; }

        [JsonProperty("barricades_deployed")]
        public int BarricadesDeployed { get; private set; }

        [JsonProperty("blind_kills")]
        public int BlindKills { get; private set; }

        [JsonProperty("bullets_fired")]
        public int BulletsFired { get; private set; }

        [JsonProperty("bullets_hit")]
        public int BulletsHit { get; private set; }

        [JsonProperty("dbnos")]
        public int DBNOs { get; private set; }

        [JsonProperty("distance_travelled")]
        public long DistanceTravelled { get; private set; }

        [JsonProperty("gadgets_destroyed")]
        public int GadgetsDestroyed { get; private set; }

        [JsonProperty("headshots")]
        public int HeadShots { get; private set; }

        [JsonProperty("melee_kills")]
        public int MeleeKills { get; private set; }

        [JsonProperty("penetration_kills")]
        public int PenetrationKills { get; private set; }

        [JsonProperty("rappel_breaches")]
        public int RappelBreaches { get; private set; }

        [JsonProperty("reinforcements_deployed")]
        public int ReinforcementsDeployed { get; private set; }

        [JsonProperty("revives")]
        public int Revives { get; private set; }

        [JsonProperty("suicides")]
        public int Suicides { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("draws")]
        public int Draws { get; private set; }

        [JsonProperty("games_played")]
        public int GamesPlayed { get; private set; }

        [JsonProperty("kd")]
        public double KD { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("playtime")]
        private long _playTime;

        [JsonIgnore]
        public TimeSpan PlayTime => TimeSpan.FromSeconds(_playTime);

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("wl")]
        public double WinLose { get; private set; }
    }
}
