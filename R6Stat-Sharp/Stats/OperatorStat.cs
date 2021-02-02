using Newtonsoft.Json;
using R6Stats.Enums;
using R6Stats.Stats.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace R6Stats.Stats
{
    /// <summary>
    /// Represents game stats for an R6 operator
    /// </summary>
    public class OperatorStat : IGameStat, IPlayerStat
    {
        /// <summary>
        /// Name of the operator
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Counter-Terrorist Unit the operator is associated with
        /// </summary>
        [JsonProperty("ctu")]
        public string CTU { get; private set; }

        [JsonProperty("role")]
        private string _role;

        /// <summary>
        /// Role of the player: Attacker/Defender
        /// </summary>
        [JsonIgnore]
        public OperatorType Role => Enum.Parse<OperatorType>(_role, true);

        /// <summary>
        /// Number of kills scored while playing this operator
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; private set; }

        /// <summary>
        /// Number of times the player died while playing this operator
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        /// <summary>
        /// Kill/Death ratio achieved with this operator
        /// </summary>
        [JsonProperty("kd")]
        public double KD { get; private set; }

        /// <summary>
        /// Number of games won while playing this operator
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; private set; }

        /// <summary>
        /// Number of games lost while playing this operator
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; private set; }

        /// <summary>
        /// Win/Lose ratio achieved with this operator
        /// </summary>
        [JsonProperty("wl")]
        public double WinLose { get; private set; }

        /// <summary>
        /// Number of headshot kills scored with this operator
        /// </summary>
        [JsonProperty("headshots")]
        public int HeadShots { get; private set; }

        /// <summary>
        /// Number of times the player got downed while playing this operator
        /// </summary>
        [JsonProperty("dbnos")]
        public int DBNOs { get; private set; }

        /// <summary>
        /// Number of melee kills scored while playing this operator
        /// </summary>
        [JsonProperty("melee_kills")]
        public int MeleeKills { get; private set; }

        /// <summary>
        /// Experience gained while playing this operator
        /// </summary>
        [JsonProperty("experience")]
        public int Experience { get; private set; }

        [JsonProperty("playtime")]
        private long _playTime;

        /// <summary>
        /// Total time spent playing this operator
        /// </summary>
        [JsonIgnore]
        public TimeSpan PlayTime => TimeSpan.FromSeconds(_playTime);

        [JsonProperty("abilities")]
        private List<OperatorAbility> _operatorAbilities;

        /// <summary>
        /// Stats for each operator ability, keyed with the abilities name
        /// </summary>
        [JsonIgnore]
        public IReadOnlyDictionary<string, int> OperatorAbilities => _operatorAbilities.ToDictionary(x => x.Ability, x => x.Value);

        /// <summary>
        /// Badge for the <see cref="OperatorStat.CTU"/>
        /// </summary>
        [JsonProperty("badge_image")]
        public string BadgeImg { get; private set; }
    }

    internal class OperatorAbility
    {
        [JsonProperty("ability")]
        public string Ability { get; private set; }

        [JsonProperty("value")]
        public int Value { get; private set; }
    }
}
