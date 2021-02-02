using Newtonsoft.Json;
using R6Stats.Stats.Interfaces;
using System;

namespace R6Stats.Stats
{
    /// <summary>
    /// Represents the general statistics for a player
    /// </summary>
    public class GeneralStat : IGenericStat, IPlayerStat
    {
        /// <summary>
        /// Number of assists scored by the player
        /// </summary>
        [JsonProperty("assists")]
        public int Assists { get; private set; }

        /// <summary>
        /// Number of barricades deployed by the player
        /// </summary>
        [JsonProperty("barricades_deployed")]
        public int BarricadesDeployed { get; private set; }

        /// <summary>
        /// Number of blind kills gotten by the player
        /// </summary>
        [JsonProperty("blind_kills")]
        public int BlindKills { get; private set; }

        /// <summary>
        /// Number of bullets fired by the player
        /// </summary>
        [JsonProperty("bullets_fired")]
        public int BulletsFired { get; private set; }

        /// <summary>
        /// Number of bullets hit an opponent
        /// </summary>
        [JsonProperty("bullets_hit")]
        public int BulletsHit { get; private set; }
        
        /// <summary>
        /// Number of times the player got downed
        /// </summary>
        [JsonProperty("dbnos")]
        public int DBNOs { get; private set; }

        /// <summary>
        /// Total distance travelled by the player
        /// </summary>
        [JsonProperty("distance_travelled")]
        public long DistanceTravelled { get; private set; }

        /// <summary>
        /// Number of gadgets destroyed by the player
        /// </summary>
        [JsonProperty("gadgets_destroyed")]
        public int GadgetsDestroyed { get; private set; }

        /// <summary>
        /// Number of headshots the player got
        /// </summary>
        [JsonProperty("headshots")]
        public int HeadShots { get; private set; }

        /// <summary>
        /// Number of times the players killed an opponent with melee attack
        /// </summary>
        [JsonProperty("melee_kills")]
        public int MeleeKills { get; private set; }

        /// <summary>
        /// Number of penetration kills scored by the player
        /// </summary>
        [JsonProperty("penetration_kills")]
        public int PenetrationKills { get; private set; }

        /// <summary>
        /// Number of times the player breached an obstruction while rappeling
        /// </summary>
        [JsonProperty("rappel_breaches")]
        public int RappelBreaches { get; private set; }

        /// <summary>
        /// Number of reinforcements deployed by the player
        /// </summary>
        [JsonProperty("reinforcements_deployed")]
        public int ReinforcementsDeployed { get; private set; }

        /// <summary>
        /// Number of times the player revived a teammate
        /// </summary>
        [JsonProperty("revives")]
        public int Revives { get; private set; }

        /// <summary>
        /// Number of times the player killed themselves
        /// </summary>
        [JsonProperty("suicides")]
        public int Suicides { get; private set; }

        /// <summary>
        /// Number of times the player died
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        /// <summary>
        /// Number of times the player traded kills with an opponent
        /// </summary>
        [JsonProperty("draws")]
        public int Draws { get; private set; }

        /// <summary>
        /// Total number of games played
        /// </summary>
        [JsonProperty("games_played")]
        public int GamesPlayed { get; private set; }

        /// <summary>
        /// Kill/Death ratio of the player
        /// </summary>
        [JsonProperty("kd")]
        public double KD { get; private set; }

        /// <summary>
        /// Number of times the player killed an opponent
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; private set; }

        /// <summary>
        /// Number of times the player lsot a game
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("playtime")]
        private long _playTime;

        /// <summary>
        /// Total time spent playing the game
        /// </summary>
        [JsonIgnore]
        public TimeSpan PlayTime => TimeSpan.FromSeconds(_playTime);

        /// <summary>
        /// Number of games won by the player
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; private set; }

        /// <summary>
        /// Win/Lose rati of the player
        /// </summary>
        [JsonProperty("wl")]
        public double WinLose { get; private set; }
    }
}
